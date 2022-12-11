using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notes.BLL.Interfaces;
using Notes.BLL.Services;
using Notes.Domain.Entities;
using System.Collections.Generic;

namespace Notes.Server.Controllers
{
    [Route("api/colors")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            this._colorService = colorService;
        }

        [HttpGet]
        public IEnumerable<ColorCard> GetAll()
        {
            return _colorService.GetColors();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ColorCard color = await _colorService.GetColor(id);
            if (color != null)
            {
                return Ok(color);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
