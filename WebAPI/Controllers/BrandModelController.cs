using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandModelController : ControllerBase
    {
        IBrandModelService _brandModelService;
        public BrandModelController(IBrandModelService brandModelService)
        {
            _brandModelService = brandModelService;
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

        [HttpGet("getBrandModelByBrandId")]
        public IActionResult GetCarModel(int id)
        {
            var result = _brandModelService.GetBrandModelById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("getBrandModelsByBrandId")]
        public IActionResult GetBrandModelsByBrandId(int brandId)
        {
            var result = _brandModelService.GetBrandModelsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("brandModelAdd")]
        public IActionResult ModelAdd(BrandModel brandModel)
        {
            var result = _brandModelService.Add(brandModel);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }



    }
}
