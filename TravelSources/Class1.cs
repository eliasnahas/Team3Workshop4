using System.Net.Http.Headers;
using TravelExpertsData;
namespace TravelSources
{
    public static class TravelSource
    {
        public static List<Product>? GetProducts()
        {
            using (TravelExpertsContext db = new TravelExpertsContext()) // connect to the database and get data
            {
                var prod = db.Products.Select(p => new
                {
                    p.ProductId,
                    p.ProdName
                }).ToList();
                return prod;
            }
        }
    }
}