using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using TravelExpertsData;
using TravelSources;

namespace TravelExpertsMVC.Controllers
{
    public class PackagesController : Controller
    {
        private TravelExpertsContext db { get; set; }

        public PackagesController(TravelExpertsContext db)
        {
            this.db = db;
        }

        // Available Packages page
        public IActionResult Index()
        {
            return View();
        }


        // Assigns the given package to the signed in user, and displays a page for confirming the purchase
        [Authorize]
        public IActionResult ConfirmPurchase(int packageId)
        {
            CustomerPackage custPack = new();
            
            try
            {
                custPack.CustomerId = (int)TempData["CustId"]; // Grab customerID from TempData
                TempData["CustId"] = custPack.CustomerId; // reset for next package purchase
                custPack.PackageId = packageId;
                TravelSource.AddCustomerPackage(db, custPack);
                return View();

            }
            catch
            {
                TempData["PurchaseError"] = true;
                return View();
            } 
            
            
        }
    }
}
