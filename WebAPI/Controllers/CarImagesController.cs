using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getallbycarid")]
        public IActionResult Get(int id)
        {
            var result = _carImageService.GetAllByCarId(id);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile image, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(image, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
