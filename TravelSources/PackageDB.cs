using Microsoft.EntityFrameworkCore;
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

        public static bool DeleteCustomerPackage(TravelExpertsContext db, int custPackID)
        {
            try
            {
                CustomerPackage custPack = db.CustomerPackages.Find(custPackID);
                db.CustomerPackages.Remove(custPack);
                db.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
