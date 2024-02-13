using Microsoft.AspNetCore.Mvc;
using TravelExpertsData;

namespace TravelExpertsMVC.Components
{
    public class AgentsByAgencyViewComponent : ViewComponent
    {
        private TravelExpertsContext _db;

        public AgentsByAgencyViewComponent(TravelExpertsContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Agent> agents;
            agents = AgentDB.GetAgentsByAgency(_db, id);
            return View(agents);
        }
    }
}
