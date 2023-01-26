using Microsoft.AspNetCore.Mvc;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Controllers
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
        public IEnumerable<ColorViewModel> GetAll()
        {
            return _colorService.GetColors();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var color = await _colorService.GetColor(id);
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
