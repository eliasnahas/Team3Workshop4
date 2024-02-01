using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
using Microsoft.Data.SqlClient;
namespace TravelSources
{
    public static class TravelSource
    {
        // Gets and returns Products table as a List<Product> - by: Jack Li/Lance Salvador
        public static List<Product> GetProducts()
        {
            // retrieving List<T> from database - by: Jack Li
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var prod = db.Products.Select(p => new
                {
                    p.ProductId,
                    p.ProdName
                }).ToList();

                // conversion from List<T> to List<Product> - by: Lance Salvador
                var result = prod.Select(p => new Product
                {
                    ProductId = p.ProductId,
                    ProdName = p.ProdName
                }).Cast<Product>().ToList();
                return result;
            }
        }


        public static List<ProductsSupplier> GetProdSupps()
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var prodSupp = (from ps in db.ProductsSuppliers
                                select new
                                {
                                    ps.ProductSupplierId,
                                    ps.ProductId,
                                    ps.SupplierId
                                }).ToList();
                var result = prodSupp.Select(ps => new ProductsSupplier
                {
                    ProductSupplierId = ps.ProductSupplierId,
                    ProductId = ps.ProductId,
                    SupplierId = ps.SupplierId
                }).Cast<ProductsSupplier>().ToList();
                return result;
            }
        }

        public static List<Package> GetPackages()
        {
            List<Package> result = new List<Package>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                result = (from p in db.Packages
                              select new Package
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

        public static Package FindPackage(int packageId)
        {
            Package result = null;

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (db.Packages.Find(packageId) != null)
                {
                    result = db.Packages.Find(packageId);
                }
            }
            return result;
        }

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

        public static void DeletePackage(Package package)
        {
            if (package != null)
            {
                using (TravelExpertsContext db= new TravelExpertsContext())
                {
                    db.Packages.Remove(package);
                    db.SaveChanges();
                }
            }
        }

        public static List<ProdSuppNames> GetProductsSupplierByPackage(int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Package package = db.Packages.Find(packageId);


                //var packagesProductsSuppliers = (from p in db.ProductsSuppliers
                //                                 select new ProductsSupplier
                //                                 {
                //                                     p.Product.ProdName,
                //                                     p.Supplier?.SupName
                //                                 }.ToList();

                var packagesProductsSuppliers = package?.ProductSuppliers
                            .Select(p => new
                            {
                                Product = p.Product?.ProdName,
                                Supplier = p.Supplier?.SupName
                            })
                            .ToList();
                var result = packagesProductsSuppliers?.Select(p => new ProdSuppNames
                {
                    SuppName = p.Supplier,
                    ProdName = p.Product
                }).Cast<ProdSuppNames>().ToList();
                return result;
            }
            // ProdSuppNames pair = new ProdSuppNames("blar", "wobbegong");

        }
    }
    public partial class ProdSuppNames
    {
        public string? ProdName { get; set; }
        public string? SuppName { get; set; }

    }

}