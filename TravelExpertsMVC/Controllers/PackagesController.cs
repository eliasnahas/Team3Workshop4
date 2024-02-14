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

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult ConfirmPurchase(int packageId)
        {
            CustomerPackage custPack = new();
            if (TempData["customerID"] != null)
            {
                custPack.CustomerId = (int)TempData["customerID"]!;
                custPack.PackageId = packageId;
                Package package = PackageDB.FindPackage(db, packageId);
                TravelSource.AddCustomerPackage(db, custPack);
                return View();
            }
            bool errorFound = true;
            return View(errorFound);
        }
    }
}
