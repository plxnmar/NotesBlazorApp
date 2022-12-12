
using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.BLL.Interfaces;
using NotesBlazorApp.DAL;
using NotesBlazorApp.Domain.Entities;

namespace NotesBlazorApp.BLL.Services
{
    public class ColorService : IColorService
    {
        readonly ApplicationDbContext _dbContext = new();

        public ColorService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ColorCard> GetColors()
        {
            try
            {
                return _dbContext.ColorCards.ToList();
            }

            catch
            {
                throw;
            }
        }

        public async Task<ColorCard> GetColor(int id)
        {
            try
            {
                var color = await _dbContext.ColorCards.FirstOrDefaultAsync(x => x.Id == id);

                if (color != null)
                {
                    return color;
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
