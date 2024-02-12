using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
using GridData;
using Microsoft.Identity.Client;
using System.Linq.Expressions;
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


        public static List<ProductsSupplierBT> GetProdSupps()
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var result = (from ps in db.ProductsSuppliers
                                join p in db.Products on ps.ProductId equals p.ProductId
                                join s in db.Suppliers on ps.SupplierId equals s.SupplierId
                                orderby ps.ProductSupplierId
                                select new ProductsSupplierBT
                                {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                   SupName = s.SupName
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
                    SupName = s.SupName!
                }).ToList();
                return result;
            }

        }        

        public static List<ProdSuppNames>? GetProductsSupplierByPackage(int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Package? package = db.Packages.Find(packageId);

                var result = (from p in db.Packages
                              join pps in db.PackagesProductsSuppliers on p.PackageId equals pps.PackageId
                              join ps in db.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                              where p.PackageId == package!.PackageId
                              select new ProdSuppNames
                              {
                                  ProdName = ps.Product!.ProdName,
                                  SuppName = ps.Supplier!.SupName
                              }).ToList();


                return result;
            }
        }
        public static List<PackProdSuppIds> GetPacksProdsSupps()
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var result = db.PackagesProductsSuppliers.Select(p => new PackProdSuppIds
                {
                    PackageProductSupplierId = p.PackageProductSupplierId,
                    PackageId = p.PackageId,
                    ProductSupplierId = p.ProductSupplierId
                }).OrderBy(pps => pps.PackageId).ThenBy(pps => pps.PackageProductSupplierId).ToList();
                return result;
            }
        }

        public static PackagesProductsSupplier GetPackProdSuppFromId(int PackProdSuppId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var result = db.PackagesProductsSuppliers.Find(PackProdSuppId);
                return result!;
            }
        }

        public static void AddToPackProdSupps(PackagesProductsSupplier entry)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                if (entry != null)
                {
                    db.PackagesProductsSuppliers.Add(entry);
                    db.SaveChanges();
                }
            }
        }
        public static void ModifyPackProdSupp(PackagesProductsSupplier entry)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var dbEntry = db.PackagesProductsSuppliers.FirstOrDefault(row => row.PackageProductSupplierId == entry.PackageProductSupplierId);
                
                if (dbEntry != null)
                {
                    dbEntry.ProductSupplierId = entry.ProductSupplierId;
                    dbEntry.PackageId = entry.PackageId;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception) 
                    {
                        throw; // replace with textbox handling after finding what error it *should* throw
                    }
                }
            }
        }

        public static void DeletePackProdSupp(PackagesProductsSupplier entry)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                db.PackagesProductsSuppliers.Remove(entry); 
                db.SaveChanges();
            }
        }
    }

    
    

}