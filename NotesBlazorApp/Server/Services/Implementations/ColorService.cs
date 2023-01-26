
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Server.Data;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared.Models;
using NotesBlazorApp.Shared.ViewModels;

namespace NotesBlazorApp.Server.Services
{
	public class ColorService : IColorService
	{
		readonly ApplicationDbContext _dbContext;
		private readonly IMapper _mapper;

		public ColorService(ApplicationDbContext dbContext, IMapper mapper)
		{
			_dbContext = dbContext;
			_mapper = mapper;
		}

		public IEnumerable<ColorViewModel> GetColors()
		{
			try
			{
				return _mapper.Map<IEnumerable<ColorViewModel>>(_dbContext.ColorCards);
			}

			catch
			{
				throw;
			}
		}

		public async Task<ColorViewModel> GetColor(int id)
		{
			try
			{
				var color = await _dbContext.ColorCards.FirstOrDefaultAsync(x => x.Id == id);

				if (color != null)
				{
					return _mapper.Map<ColorViewModel>(color);
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
