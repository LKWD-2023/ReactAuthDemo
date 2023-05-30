using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactAuthDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        [Route("getdata")]
        [HttpGet]
        [Authorize]
        public object GetData()
        {
            return new { number = new Random().Next(1, 10000) };
        }
    }
}
