using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCartController : ControllerBase
    {
        ICreditCardService _creditCardService;
        public CreditCartController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _creditCardService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("getCardsByUserId")]
        public IActionResult GetCarsByUserId(int userId)
        {
            var result = _creditCardService.GetCardsByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _creditCardService.Get(id);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("add")]
        public IActionResult Add(CreditCard creditCard)
        {
            var result = _creditCardService.Add(creditCard);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("update")]
        public IActionResult Update(CreditCard creditCard)
        {
            var result = _creditCardService.Update(creditCard);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("delete")]
        public IActionResult Delete(CreditCard creditCard)
        {
            var result = _creditCardService.Delete(creditCard);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }






    }
}
