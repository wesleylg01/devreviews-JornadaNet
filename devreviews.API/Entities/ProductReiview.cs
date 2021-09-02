using System;
namespace devreviews.API.Entities
{
    public class ProductReiview
    {
        public ProductReiview(string author, int rating, string commetns, int productId)
        {
            Author = author;
            Rating = rating;
            Commetns = commetns;
            RegisteredAt = DateTime.Now;
            ProductId = productId;
        }

        public int Id { get; private set; }
        public string Author { get; private set; }
        public int Rating { get; private set; }
        public string Commetns { get; private set; }
        public DateTime RegisteredAt { get; private set; }
        public int ProductId { get; private set; }
    }
}