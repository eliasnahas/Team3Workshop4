using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace TravelSources
{
    public class PackageDB
    {
        // Finds package by ID - by: Elias Nahas
        public static Package FindPackage(TravelExpertsContext db, int packageId)
        {
            Package result = null!;

            if (db.Packages.Find(packageId) != null)
            {
                result = db.Packages.Find(packageId)!;
            }
            
            return result;
        }
    }
}
