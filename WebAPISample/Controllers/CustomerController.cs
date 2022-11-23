using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServcie _customerService;
        public CustomerController(ICustomerServcie customerServcie)
        {
            _customerService = customerServcie;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var List =  _customerService.GetAll();

            return Ok(List);
        }

    }
}
