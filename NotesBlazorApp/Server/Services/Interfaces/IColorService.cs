using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Interfaces
{
    public interface IColorService
    {
        IEnumerable<ColorCard> GetColors();
        Task<ColorCard> GetColor(int id);
    }
}
