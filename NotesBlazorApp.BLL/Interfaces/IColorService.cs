using NotesBlazorApp.Domain.Entities;

namespace NotesBlazorApp.BLL.Interfaces
{
    public interface IColorService
    {
        IEnumerable<ColorCard> GetColors();
        Task<ColorCard> GetColor(int id);
    }
}
