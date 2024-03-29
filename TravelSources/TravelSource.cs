﻿using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
using GridData;
using Microsoft.Identity.Client;
using System.Linq.Expressions;
using TravelExpertsData;
using System.Collections.Generic;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
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

        // Adds product from package - by: Elias Nahas
        public static void AddPackageProduct(ProdSuppNames itemToTransfer, int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Product prod = db.Products.Where(p => p.ProdName == itemToTransfer.ProdName).FirstOrDefault();
                Supplier supp = db.Suppliers.Where(s => s.SupName == itemToTransfer.SuppName).FirstOrDefault();
                ProductsSupplier prodSupp = db.ProductsSuppliers.Where(ps => ps.ProductId == prod.ProductId).Where(ps => ps.SupplierId == supp.SupplierId).FirstOrDefault();
                PackagesProductsSupplier ppsToAdd = new PackagesProductsSupplier()
                {
                    PackageId = packageId,
                    ProductSupplierId = prodSupp.ProductSupplierId
                };
                db.PackagesProductsSuppliers.Add(ppsToAdd);
                db.SaveChanges();
            }
        }

        // Removes product from package - by: Elias Nahas
        public static void RemovePackageProduct(ProdSuppNames itemToTransfer, int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                Product prod = db.Products.Where(p => p.ProdName == itemToTransfer.ProdName).FirstOrDefault();
                Supplier supp = db.Suppliers.Where(s => s.SupName == itemToTransfer.SuppName).FirstOrDefault();
                ProductsSupplier prodSupp = db.ProductsSuppliers.Where(ps => ps.ProductId == prod.ProductId).Where(ps => ps.SupplierId == supp.SupplierId).FirstOrDefault();
                PackagesProductsSupplier ppsToDelete = db.PackagesProductsSuppliers.Where(pps => packageId == packageId).Where(pps => pps.ProductSupplierId == prodSupp.ProductSupplierId).FirstOrDefault();
                db.PackagesProductsSuppliers.Remove(ppsToDelete);
                db.SaveChanges();
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

        // Gets list of Products and their Suppliers by package ID - by: Lance Salvador
        public static List<ProdSuppNames>? GetProductsSupplierByPackage(int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var result = (from p in db.Packages
                              join pps in db.PackagesProductsSuppliers on p.PackageId equals pps.PackageId
                              join ps in db.ProductsSuppliers on pps.ProductSupplierId equals ps.ProductSupplierId
                              where p.PackageId == packageId
                              select new ProdSuppNames
                              {
                                  ProdName = ps.Product!.ProdName,
                                  SuppName = ps.Supplier!.SupName
                              }).OrderBy(ps => ps.ProdName).ThenBy(ps => ps.SuppName).ToList();
                return result;
            }
        }

        // Gets list of Products that are not in a Package by package ID - by: Elias Nahas
        public static List<ProdSuppNames> GetRemainingProductsSuppliersByPackage(int packageId)
        {
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var psIDs = db.PackagesProductsSuppliers.Where(p => p.PackageId == packageId).Select(ps => ps.ProductSupplierId).ToList();

                var psRemaining = db.ProductsSuppliers.Where(x => !psIDs.Contains(x.ProductSupplierId))
                    .Select(ps => new ProdSuppNames
                    {
                        ProdName = ps.Product!.ProdName,
                        SuppName = ps.Supplier!.SupName
                    })
                    .OrderBy(ps => ps.ProdName).ThenBy(ps => ps.SuppName).ToList();
                return psRemaining;
            }
        }

        // By: Lance Salvador
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




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Functions for TravelExperts Website
        // (containerized)


        /// <summary>
        /// Adds a new CustomerPackage entry into the database
        /// </summary>
        /// <param name="db">Context object</param>
        /// <param name="customerPackage">CustomerPackage to add to the database</param>
        /// By: Lance Salvador
        public static void AddCustomerPackage(TravelExpertsContext db, CustomerPackage customerPackage)
        {
            db.CustomerPackages.Add(customerPackage);
            db.SaveChanges();
        }

        /// <summary>
        /// Get Packages that belong to the given customerID
        /// </summary>
        /// <param name="db">Context object</param>
        /// <param name="customerID">The ID of the Customer to query</param>
        /// <returns>A list of packages that belong to the given customerID, and the total cost owed.</returns>
        /// <exception cref="NotImplementedException"></exception>
        /// By: Lance Salvador
        public static (List<Package>, decimal) GetPackagesDataByCustomerId(TravelExpertsContext db, int customerID)
        {
            
            List<Package> packages = db.Packages
                .Join(db.CustomerPackages, // Join tables to get the package data of only purchased packages
                package => package.PackageId,
                custPackage => custPackage.PackageId,
                (package, custPackage) => new { package, custPackage })
                    .Where(x => x.custPackage.CustomerId == customerID) // Only get purchased packages of this customer
                    .Select(x => x.package) // select only the columns of Package (make List<Package> valid)
                    .OrderBy(p => p.PackageId)
                    .ToList();
            decimal totalCost = 0m;
            foreach(Package package in packages)
            {
                if(package.PkgAgencyCommission != null)
                {
                    totalCost += (decimal)package.PkgBasePrice;
                }
                else
                {
                    totalCost += package.PkgBasePrice;
                }
            }
            return (packages, totalCost);
        }
    }

    
    

}