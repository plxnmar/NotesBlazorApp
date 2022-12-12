using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Controllers
{
    [Authorize]
    [Route("api/notes")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly INoteService _noteService;

        public NotesController(INoteService noteService, UserManager<ApplicationUser> userManager)
        {
            this._noteService = noteService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Note>> GetAll()
        {
            var user = await userManager.GetUserAsync(User);

            if (user != null)
            {
                return _noteService.GetNotes(user.Id);
            }
            return null;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Note note = await _noteService.GetNote(id);
            if (note != null)
            {
                return Ok(note);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Note Note)
        {
            var user = await userManager.GetUserAsync(User);

            if (user != null)
            {
                var res = await _noteService.AddNote(Note, user.Id);
                return Ok(res);
            }

            return NotFound();

        }

        [HttpPut]
        public void Put(Note note)
        {
            _noteService.UpdateNote(note);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _noteService.DeleteNote(id);
            return Ok();
        }

    }
}
