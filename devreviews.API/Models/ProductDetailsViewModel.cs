using System.Collections.Generic;
using System;

namespace devreviews.API.Models
{
    public class ProductDetailsViewModel
    {
        public ProductDetailsViewModel(int id, string title, string description, decimal price, DateTime registeredAt, List<ProductRevieInputModel> reviews)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            RegisteredAt = registeredAt;
            Reviews = reviews;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public DateTime RegisteredAt { get; private set; }

        public List<ProductRevieInputModel> Reviews {get; private set;}
    }

    public class ProductRevieInputModel
    {
        public ProductRevieInputModel(int id, string author, int rating, string comments, DateTime registeredAt)
        {
            Id = id;
            Author = author;
            Rating = rating;
            Comments = comments;
            RegisteredAt = registeredAt;
        }

        public int Id { get; private set; }
        public string Author { get; private set; }
        public int Rating { get; private set; }
        public string Comments { get; private set; }
        public DateTime RegisteredAt { get; private set; }
    }
}