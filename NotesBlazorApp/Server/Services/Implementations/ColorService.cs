
using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Server.Data;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Services
{
    public class ColorService : IColorService
    {
        readonly ApplicationDbContext _dbContext;

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
