using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Server.Data;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Services
{
	public class NoteService : INoteService
	{
		private readonly ApplicationDbContext _dbContext;
		private readonly IMapper _mapper;

		public NoteService(ApplicationDbContext dbContext, IMapper mapper)
		{
			_dbContext = dbContext;
			_mapper = mapper;
		}

		public IEnumerable<NoteViewModel> GetNotes(string userId)
		{
			try
			{
				var notes = _mapper.Map<IEnumerable<NoteViewModel>>
					(_dbContext.Notes
					.Include(x => x.ColorCard)
					.Where(x => x.UserId == userId)
					.OrderByDescending(x => x.ChangedDate));

				return notes;
			}

			catch
			{
				throw;
			}
		}

		public async Task<NoteViewModel> GetNote(int id)
		{
			try
			{
				var note = _mapper.Map<NoteViewModel>
					(await _dbContext.Notes
					.Include(x => x.ColorCard)
					.FirstOrDefaultAsync(x => x.Id == id));

				if (note != null)
				{
					return note;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}


		public async Task<bool> AddNote(NoteViewModel noteViewModel, string userId)
		{
			try
			{
				var noteModel = _mapper.Map<Note>(noteViewModel);

				noteModel.UserId = userId;

				await _dbContext.Notes.AddAsync(noteModel);
				await _dbContext.SaveChangesAsync();
				return true;
			}
			catch
			{
				throw;
			}
		}

		public async Task<bool> UpdateNote(NoteViewModel noteViewModel, string userId)
		{
			try
			{
				if (noteViewModel != null)
				{
					var noteModel = _mapper.Map<Note>(noteViewModel);

					noteModel.UserId = userId;

					_dbContext.Entry(noteModel).State = EntityState.Modified;
					await _dbContext.SaveChangesAsync();
					return true;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}


		public async Task<bool> DeleteNote(int id)
		{
			try
			{
				var note = await _dbContext.Notes.FindAsync(id);
				if (note != null)
				{
					_dbContext.Notes.Remove(note);
					await _dbContext.SaveChangesAsync();
					return true;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}
	}
}
