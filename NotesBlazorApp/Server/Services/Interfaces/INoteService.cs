using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Interfaces
{
    public interface INoteService
    {
        IEnumerable<NoteViewModel> GetNotes(string userId);
        Task<NoteViewModel> GetNote(int id);
        Task<bool> AddNote(NoteViewModel note, string userId);
        Task<bool> UpdateNote(NoteViewModel note, string userId);
        Task<bool> DeleteNote(int id);
    }
}
