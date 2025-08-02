using Microsoft.AspNetCore.Mvc;
using Vicporsy.Contract.Request;
using Vicporsy.Wrapper;

namespace uxcomexweb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly ClientWrapper _clientWrapper;
        public ClientController(ClientWrapper clientWrapper)
        {
            _clientWrapper = clientWrapper;
        }
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _clientWrapper.GetAll();
            return Ok(response);
        }

        [Route("RemoveClient/{id}")]
        public async Task<IActionResult> RemoveClient(int id)
        {
            var response = await _clientWrapper.Delete(id);
            return Ok(response);
        }

        [Route("Post")]
        public async Task<IActionResult> Post(ClientRequest request)
        {
            var response = await _clientWrapper.Post(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("Put")]
        public async Task<IActionResult> Put([FromBody] ClientRequest request)
        {
            var response = await _clientWrapper.Put(request);
            return Ok(response);
        }
    }
}
