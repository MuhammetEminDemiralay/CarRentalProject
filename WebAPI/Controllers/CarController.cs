using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet("getall")]
        public IActionResult GetAl()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _carService.Get(id);
            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("getByBrandCategory")]
        public IActionResult GetByBrandCategory(int brandId)
        {
            var result = _carService.GetByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("carDetail")]
        public IActionResult CarDetail()
        {
            var result = _carService.GetCarDetail();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpGet("getCarDetailsByBrand")]
        public IActionResult BrandCarCategory(int brandId)
        {
            var result = _carService.GetCarDetailBrand(brandId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpGet("getCarDetailsByColor")]
        public IActionResult ColorCarCategory(int colorId)
        {
            var result = _carService.GetCarDetailColor(colorId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("getMorCarDetails")]
        public IActionResult GetMoreCarDetails(int carId)
        {
            var result = _carService.GetMoreCarDetails(carId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

    }
}
