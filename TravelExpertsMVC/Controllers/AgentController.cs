using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelExpertsData;

namespace TravelExpertsMVC.Controllers
{
    public class AgentController : Controller
    {
        private TravelExpertsContext? _db {  get; set; }

        public AgentController(TravelExpertsContext db)
        {
            _db = db;
        }

        // Will be called from Ajax function
        // "Contact Us" page - By: Elias Nahas
        public IActionResult GetAgentsByAgency(int id)
        {
            // Invoke the view component
            return ViewComponent("AgentsByAgency", id);
        }

        // [HttpGet]
        // Get a list of Agents by Agency ID
        // "Contact Us" page - By: Elias Nahas
        public IActionResult AgentsByAgency(int id = 1)
        {
            try
            {
                // Prepare data for the drop down list
                List<Agency> agencies = AgencyDB.GetAgencies(_db!);
                var list = new SelectList(agencies, "AgencyId", "AgncyCity");
                ViewBag.Agencies = list;
            }
            catch (Exception)
            {
                TempData["Message"] = "Database connection error. Try again later.";
                TempData["IsError"] = true;
            }
            return View(); // this view will have Ajax call to the view component
        }
    }
}
