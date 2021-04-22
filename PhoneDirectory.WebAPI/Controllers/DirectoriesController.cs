using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Business.Abstract;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneDirectory.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoriesController : ControllerBase
    {
        IDirectoryService _directoryService;
        public DirectoriesController(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }

        [HttpPost("add")]
        public IActionResult Add(Directory directory)
        {
            var result = _directoryService.Add(directory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Directory directory)
        {
            var result = _directoryService.Delete(directory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Directory directory)
        {
            var result = _directoryService.Update(directory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _directoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _directoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
