using devreviews.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace devreviews.API.Controllers
{
    [ApiController]
    [Route("api/produtcs/{productId}/productreviews")]
    public class ProductReviewsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById (int productId, int id){
            return Ok();
        }
        
        [HttpPost]
        public IActionResult Post(int productId, AddProductRevieInputModel model){
            return CreatedAtAction(nameof(GetById), new {id = 1, productId = 2}, model);
        }

    }
}