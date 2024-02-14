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
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult ConfirmPurchase()
        {
            return View();
        }

        public IActionResult ConfirmPurchase(int id)
        {

            return View();
        }
    }
}
