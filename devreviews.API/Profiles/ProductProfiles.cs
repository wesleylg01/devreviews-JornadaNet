using AutoMapper;
using devreviews.API.Entities;
using devreviews.API.Models;

namespace devreviews.API.Profiles
{
    public class ProductProfiles : Profile
    {
        public ProductProfiles (){
            
            CreateMap<ProductReiview, ProductRevieInputModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, ProductDetailsViewModel>();
        }
    }
}