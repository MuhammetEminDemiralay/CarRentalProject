using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {

        ICarImageService _imageService;

        public CarImageController(ICarImageService imageService)
        {
            _imageService = imageService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getİmagesByCarId")]
        public IActionResult GetİmagesByCarId(int carId)
        {
            var result = _imageService.GetImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile[] files, [FromForm] CarImage carImage)
        {
            var result = _imageService.AddCollective(files, carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage image)
        {
            var result = _imageService.Delete(image);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

    }
}
