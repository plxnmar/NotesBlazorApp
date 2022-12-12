using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Server.Data;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Services
{
    public class NoteService : INoteService
    {
        readonly ApplicationDbContext _dbContext;

        public NoteService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Note> GetNotes(string userId)
        {
            try
            {
                var notes = _dbContext.Notes
                    .Include(x => x.ColorCard).ToList()
                    .Where(x => x.UserId == userId)
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


        public async Task<bool> AddNote(Note note, string userId)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == userId);
                if (user != null)
                {
                    note.UserId = userId;
                    note.User = user;

                    await _dbContext.Notes.AddAsync(note);
                    _dbContext.SaveChanges();
                    return true;
                }

                return false;
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
