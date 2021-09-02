using devreviews.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace devreviews.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // Get para api/products
        [HttpGet]
        public IActionResult GetAll(){
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByid(int id){
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AddProductinputModels model){
            return CreatedAtAction(nameof(GetByid), new {id = 1}, model);
        }

        [HttpPut("{id")]
        public IActionResult Put (int id, UpdateProductInputModel model){
            return NoContent ();
        }

    }
}