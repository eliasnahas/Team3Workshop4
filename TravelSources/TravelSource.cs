using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
using GridData;
namespace TravelSources
{
    public static class TravelSource
    {
        // Gets and returns Products table as a List<Product> - by: Jack Li/Lance Salvador
        public static List<ProductNameID> GetProducts()
        {
            // retrieving List<T> from database - by: Jack Li
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var result = db.Products.Select(p => new ProductNameID
                {
                    ProductId = p.ProductId,
                    ProdName = p.ProdName
                }).ToList();

                return result;
            }
        }


        public static List<ProdSuppIDs> GetProdSupps()
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var result = (from ps in db.ProductsSuppliers
                                select new ProdSuppIDs
                                {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProductId = ps.ProductId,
                                    SupplierId = ps.SupplierId
                                }).ToList();
                return result;
            }
        }

        // Gets Packages from database - by: Elias Nahas
        public static List<PackageData> GetPackages()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var result = (from p in db.Packages
                              select new PackageData
                              {
                                  PackageId = p.PackageId,
                                  PkgName = p.PkgName,
                                  PkgStartDate = p.PkgStartDate,
                                  PkgEndDate = p.PkgEndDate,
                                  PkgDesc = p.PkgDesc,
                                  PkgBasePrice = p.PkgBasePrice,
                                  PkgAgencyCommission = p.PkgAgencyCommission
                              }).ToList();
                return result;
            }
        }

        // Finds package by ID - by: Elias Nahas
        public static Package FindPackage(int packageId)
        {
            Package result = null!;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (db.Packages.Find(packageId) != null)
                {
                    result = db.Packages.Find(packageId)!;
                }
            }
            return result;
        }

        // Adds package to database - by: Elias Nahas
        public static void AddPackage(Package package)
        {
            if (package != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Packages.Add(package);
                    db.SaveChanges();
                }
            }
        }

        // Modifies package in database - by: Elias Nahas
        public static void ModifyPackage(Package package)
        {
            if (package != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Packages.Update(package);
                    db.SaveChanges();
                }
            }
        }

        // Deletes package from database - by: Elias Nahas
        public static void DeletePackage(Package package)
        {
            if (package != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.Packages.Remove(package);
                    db.SaveChanges();
                }
            }
        }


        // Gets suppliers from database - by: Gurleen Dhillon
        public static List<SupplierNameID>? GetSuppliers()
        {
            // connection to database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var result = db.Suppliers.Select(s => new SupplierNameID
                {
                    SupplierId = s.SupplierId,
                    SupName = s.SupName
                }).ToList();
                return result;
            }

        }        

        // Gets list of Products and their Suppliers by package ID - by: Lance Salvador
        public static List<ProdSuppNames>? GetProductsSupplierByPackage(int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Package? package = db.Packages.Find(packageId);

                var result = package?.ProductSuppliers
                            .Select(p => new ProdSuppNames
                            {
                                ProdName = p.Product?.ProdName,
                                SuppName = p.Supplier?.SupName
                            })
                            .ToList();
                return result;
            }
        }
    }

    
    

}