using Castle.Core.Resource;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using TravelExpertsData;
using TravelSources;

namespace TravelExpertsMVC.Controllers
{
    public class AccountController : Controller
    {
        private TravelExpertsContext db { get; set; }

        public AccountController(TravelExpertsContext db)
        {
            this.db = db;
        }

        // "Login" page - By: Elias Nahas
        public IActionResult Login(string returnUrl = "")
        {
            if (!returnUrl.IsNullOrEmpty())
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        // "Login" page - By: Elias Nahas
        [HttpPost]
        public async Task<IActionResult> LoginAsync(Customer customer) // data collected from the form
        {
            Customer cust = CustomerDB.Authenticate(db!, customer.Username, customer.Password);
            if (cust == null) // no matching username/password
            {
                return View(); // stay on the Login page
            }
            // customer != null
            // Add to the session the customer's ID as CustomerId
            HttpContext.Session.SetInt32("CustomerId", cust.CustomerId);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, cust.CustFirstName)
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                CookieAuthenticationDefaults.AuthenticationScheme); // cookies authentication
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            // ready for signing in
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
            // redirect to the protected page that initiated the login if defined
            string? returnUrl = TempData["ReturnUrl"]?.ToString();
            if (string.IsNullOrEmpty(returnUrl)) // if not return URL
                return RedirectToAction("Index", "Home"); // go to Home
            else
            {
                TempData["ReturnUrl"] = ""; // clears ReturnUrl for next login
                return Redirect(returnUrl);
            }
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        //
        public ActionResult Register(string returnUrl = "")
        {
            if (!returnUrl.IsNullOrEmpty())
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Account");
                }
                catch
                {
                    TempData["Message"] = "Database connection error. Try again later.";
                    TempData["IsError"] = true;
                    return View(customer);
                }
            }
            else
            {
                return View(customer);
            }
        }
        // Customerinfo Page - By: Jack
        [Authorize]
        public ActionResult CustomerInfo()
        {
            int? CustID = HttpContext.Session.GetInt32("CustomerId");
            Customer? customer = null;
            customer = CustomerDB.GetCustomerInfo(db!, (int)CustID);
            return View(customer);
        }
        //[HttpGet]

        public ActionResult Edit(int id)
        {
            Customer? customer = null;
            customer = CustomerDB.GetCustomerInfo(db!, id);
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer newCustomerData)
        {
            CustomerDB.UpdateCustomerInfo(db!, id, newCustomerData);
            return RedirectToAction(nameof(CustomerInfo));
        }

        public ActionResult ChangePassword(int id)
        {
            Customer? customer = null;
            customer = CustomerDB.GetCustomerInfo(db!, id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult ChangePassword(int id, Customer newCustomerData)
        {
            CustomerDB.ChangePassword(db!, id, newCustomerData);
            return RedirectToAction(nameof(CustomerInfo));
        }

         // "My Packages" page - By: Lance Salvador
        [Authorize]
        public ActionResult MyPackages()
        {
            List<Package> packages;
            int? custId = HttpContext.Session.GetInt32("CustomerId");
            packages = TravelSource.GetPackagesByCustomerPackage(db, (int)custId!);
            return View(packages);
        }
        public ActionResult DeletePackages()
        {
            return View();
        }
    }
}
