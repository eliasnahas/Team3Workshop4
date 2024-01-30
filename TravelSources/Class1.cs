using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
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

        // Gets suppliers from database - by: Gurleen Dhillon
        public static List<Supplier> GetSuppliers()
        {
            // connection to database
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var supp = db.Suppliers.Select(s => new
                {
                    s.SupplierId,
                    s.SupName
                }).ToList();
                var result = supp.Select(s => new Supplier
                {
                    SupplierId = s.SupplierId,
                    SupName = s.SupName
                }).Cast<Supplier>().ToList();
                return result;
            }

        }
    }
}