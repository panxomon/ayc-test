using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using test.api.domain;
using test.api.model;

namespace test.api.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class ProductController : ControllerBase 
    {        
        private IService<ProductModel> _retrieveProduct ;
        public ProductController(RetrieveProduct retrieveProduct)
        {
            _retrieveProduct = retrieveProduct;
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByid(int id)
        {
            var result = await _retrieveProduct.Execute(id);

            return result == null ? NotFound() : Ok(result);
        }
    }
}

