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

        public static Package? FindPackage(int packageId)
        {
            Package? result = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (db.Packages.Find(packageId) != null)
                {
                    return db.Packages.Find(packageId);
                }
            }
            return result;
        }

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