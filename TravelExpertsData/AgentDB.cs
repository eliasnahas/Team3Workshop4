using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Static methods for working with Agents table
    /// All get context object injected
    /// </summary>
    public static class AgentDB
    {
        /// <summary>
        /// Retrieve Agents belonging to an Agency
        /// </summary>
        /// <param name="db">Context object</param>
        /// <param name="agencyId">ID of the Agency</param>
        /// <returns>List of agents with matching agencyId</returns>
        public static List<Agent> GetAgentsByAgency(TravelExpertsContext db, int agencyId)
        {
            List<Agent> agents = db.Agents.Where(a => a.AgencyId == agencyId).Include(a => a.Agency).OrderBy(a => a.AgtFirstName).ToList();
            return agents;
        }
    }
}
