using Microsoft.AspNetCore.Mvc;
using Vicporsy.Contract.Request;
using Vicporsy.Wrapper;

namespace uxcomexweb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductWrapper _productWrapper;
        public ProductController(ProductWrapper productWrapper)
        {
            _productWrapper = productWrapper;
        }
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productWrapper.GetAll();

            return Ok(response);
        }

        [Route("Post")]
        public async Task<IActionResult> Post(ProductRequest request)
        {
            var response = await _productWrapper.Post(request);

            return Ok(response);
        }

        [Route("Put")]
        public async Task<IActionResult> Put(ProductRequest request)
        {
            var response = await _productWrapper.Put(request);

            return Ok(response);
        }

        [Route("RemoveProduct/{id}")]
        public async Task<IActionResult> RemoveClient(int id)
        {
            var response = await _productWrapper.Delete(id);
            return Ok(response);
        }
    }
}
