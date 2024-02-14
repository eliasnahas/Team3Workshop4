using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Static methods for working with Agencies table
    /// All get context object injected
    /// </summary>
    public static class AgencyDB
    {
        /// <summary>
        /// Retrieve all agencies
        /// Author: Elias Nahas
        /// </summary>
        /// <param name="db">Context object</param>
        /// <returns>List of agencies</returns>
        public static List<Agency> GetAgencies(TravelExpertsContext db)
        {
            List<Agency> agencies = db.Agencies.ToList();
            return agencies;
        }
    }
}
