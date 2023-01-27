using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Controllers
{
	[Authorize]
	[Route("api/notes")]
	[ApiController]
	public class NotesController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly INoteService _noteService;

		public NotesController(INoteService noteService, UserManager<ApplicationUser> userManager)
		{
			_noteService = noteService;
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IEnumerable<NoteViewModel>> GetAll()
		{
			var user = await _userManager.GetUserAsync(User);

			if (user != null)
			{
				return _noteService.GetNotes(user.Id);
			}
			return null;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var note = await _noteService.GetNote(id);
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
		public async Task<IActionResult> Post(NoteViewModel note)
		{
			var user = await _userManager.GetUserAsync(User);

			if (user != null)
			{
				var res = await _noteService.AddNote(note, user.Id);
				return Ok(res);
			}

			return NotFound();
		}

		[HttpPut]
		public async Task Put(NoteViewModel note)
		{
			var user = await _userManager.GetUserAsync(User);

			if (user != null)
			{
				await _noteService.UpdateNote(note, user.Id);
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			await _noteService.DeleteNote(id);
			return Ok();
		}
	}
}
