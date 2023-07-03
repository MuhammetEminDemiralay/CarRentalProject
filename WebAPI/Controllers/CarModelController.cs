using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        IBrandModelService _brandModelService;
        public CarModelController(IBrandModelService brandModelService)
        {
            _brandModelService = brandModelService;
        }

        [HttpPost("carModelAdd")]
        public IActionResult ModelAdd(CarModel brandModel)
        {
            var result = _brandModelService.Add(brandModel);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandModelService.GetAll(); ;
            if (result.Success)
            {
                return Ok(result);
            }
            
            return BadRequest();
        }

        [HttpGet("getCarModel")]
        public IActionResult GetCarModel(int id)
        {
            var result = _brandModelService.GetByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }



    }
}
