using System.Collections.Generic;
using devreviews.API.Entities;

namespace devreviews.API.Persistenses
{
    public class DevReviewsDbContext
    {
        public DevReviewsDbContext()
        {
            Products = new List<Product>();
        }
        public List<Product> Products {get; set;}
    }
}