using Microsoft.AspNetCore.Mvc;
using Vicporsy.Contract.Request;
using Vicporsy.Wrapper;

namespace uxcomexweb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly OrderWrapper _orderWrapper;
        public OrderController(OrderWrapper orderWrapper)
        {
            _orderWrapper = orderWrapper;
        }
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _orderWrapper.GetAll();
            return Ok(response);
        }

        [Route("Post")]
        public async Task<IActionResult> Post(OrderRequest request)
        {
            var response = await _orderWrapper.Post(request);
            return Ok(response);
        }

        [Route("Put")]
        public async Task<IActionResult> Put(OrderRequest request)
        {
            var response = await _orderWrapper.Put(request);
            return Ok(response);
        }

    }
}
