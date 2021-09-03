using System;
using System.Collections.Generic;

namespace devreviews.API.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public DateTime RegisteredAt { get; private set; }
        public List<ProductReiview> Reviews { get; private set; }
        
        public void AddReview(ProductReiview review){
            Reviews.Add(review);
        }

        public void Update(string description, decimal price){
            Description = description;
            Price = price;
        }
        public Product(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
        }
    }
}