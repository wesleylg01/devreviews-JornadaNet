using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using devreviews.API.Entities;
using devreviews.API.Models;
using devreviews.API.Persistenses;
using Microsoft.AspNetCore.Mvc;

namespace devreviews.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public readonly DevReviewsDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProductsController(DevReviewsDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        // Get para api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _dbContext.Products;

            // var productsviewmodel = products
            //                           .Select(p => new ProductViewModel(p.Id, p.Title, p.Price));
            var productsViewModel = _mapper.Map<List<ProductViewModel>>(products);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetByid(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            // var reviewsviewmodel = product
            //                  .Reviews
            //                  .Select(r => new ProductRevieInputModel(r.Id, r.Author, r.Rating, r.Commetns, r.RegisteredAt))
            //                  .ToList();

            // var productsDetails = new ProductDetailsViewModel(
            //     product.Id,
            //     product.Title,
            //     product.Description,
            //     product.Price,
            //     product.RegisteredAt,
            //     reviewsviewmodel
            // );

            var productsDetails = _mapper.Map<ProductDetailsViewModel>(product);

            return Ok(productsDetails);
        }

        [HttpPost]
        public IActionResult Post(AddProductinputModels model)
        {
            var product = new Product(model.Title, model.Descrption, model.Price);

            _dbContext.Products.Add(product);
            return CreatedAtAction(nameof(GetByid), new { id = 1 }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProductInputModel model)
        {

            if (model.Descrption.Length > 50)
            {
                return BadRequest();
            }

            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            product.Update(model.Descrption, model.Price);
            return NoContent();
        }

    }
}