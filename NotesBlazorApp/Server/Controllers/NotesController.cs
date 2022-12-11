using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notes.BLL.Interfaces;
using Notes.Domain.Entities;
using System.Collections.Generic;

namespace Notes.Server.Controllers
{
    [Route("api/notes")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;

        public NotesController(INoteService noteService)
        {
            this._noteService = noteService;
        }

        [HttpGet]
        public IEnumerable<Note> GetAll()
        {
            return _noteService.GetNotes();
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
        public void Post(Note note)
        {
            _noteService.AddNote(note);
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
