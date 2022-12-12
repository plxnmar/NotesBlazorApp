using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.BLL.Interfaces;
using NotesBlazorApp.DAL;
using NotesBlazorApp.Domain.Entities;

namespace NotesBlazorApp.BLL.Services
{
    public class NoteService : INoteService
    {
        readonly ApplicationDbContext _dbContext = new();

        public NoteService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Note> GetNotes()
        {
            try
            {
               var notes =  _dbContext.Notes
                    .Include(x => x.ColorCard).ToList()
                    .OrderByDescending(x => x.ChangedDate).ToList();
                return notes;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Note> GetNote(int id)
        {
            try
            {
                var note = await _dbContext.Notes
                    .Include(x => x.ColorCard)
                    .FirstOrDefaultAsync(x => x.Id == id);

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


        public async Task<bool> AddNote(Note note)
        {
            try
            {
                await _dbContext.Notes.AddAsync(note);
                _dbContext.SaveChanges();

                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateNote(Note note)
        {
            try
            {
                if (note != null)
                {
                    _dbContext.Entry(note).State = EntityState.Modified;
                    _dbContext.SaveChanges();
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
                var note = _dbContext.Notes.Find(id);
                if (note != null)
                {
                    _dbContext.Notes.Remove(note);
                    _dbContext.SaveChanges();
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
