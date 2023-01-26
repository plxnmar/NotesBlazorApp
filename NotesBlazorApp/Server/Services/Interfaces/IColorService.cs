using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Interfaces
{
    public interface IColorService
    {
        IEnumerable<ColorViewModel> GetColors();
        Task<ColorViewModel> GetColor(int id);
    }
}
