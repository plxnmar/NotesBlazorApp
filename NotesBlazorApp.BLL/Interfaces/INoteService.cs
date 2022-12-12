using NotesBlazorApp.Domain.Entities;

namespace NotesBlazorApp.BLL.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes();
        Task<Note> GetNote(int id);
        Task<bool> AddNote(Note note);
        bool UpdateNote(Note note);
        Task<bool> DeleteNote(int id);
    }
}
