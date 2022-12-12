using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes(string userId);
        Task<Note> GetNote(int id);
        Task<bool> AddNote(Note note, string userId);
        Task<bool> UpdateNote(Note note);
        Task<bool> DeleteNote(int id);
    }
}
