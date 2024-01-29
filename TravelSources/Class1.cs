using System.Net.Http.Headers;
using TravelExpertsData;
using System.Linq;
namespace TravelSources
{
    public static class TravelSource
    {
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
    }
}