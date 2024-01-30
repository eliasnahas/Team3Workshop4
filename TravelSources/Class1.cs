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
            // retrieving List<T> from Products database - by: Jack Li
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

        // Gets and returns Products table as a List<ProductsSupplier> - by: Jack Li/Lance Salvador
        public static List<ProductsSupplier> GetProdSupps()
        {
            // retrieving List<T> from ProductsSuppliers database - by: Jack Li
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var prodSupp = (from ps in db.ProductsSuppliers
                                select new
                                {
                                    ps.ProductSupplierId,
                                    ps.ProductId,
                                    ps.SupplierId
                                }).ToList();

                // conversion from List<T> to List<ProductsSupplier> - by: Lance Salvador
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
            List<Package> placeholder = new List<Package>();
            return placeholder;
        }
    }
}