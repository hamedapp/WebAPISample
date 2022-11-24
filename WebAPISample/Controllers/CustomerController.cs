using Domain.Dtos;
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
        public IActionResult GetAll()
        {
            var List =  _customerService.GetAll();

            return Ok(List);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(CustomerDto customerDto)
        {
            _customerService.Insert(customerDto);

            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(CustomerDto customerDto)
        {
            _customerService.Update(customerDto);

            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        public IActionResult Delete(int Id)
        {
            _customerService.Delete(Id);

            return Ok();
        }
    }
}
