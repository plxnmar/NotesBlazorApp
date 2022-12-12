using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Server.Data;
using NotesBlazorApp.Server.Interfaces;
using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Services
{
    public class UserService : IUserService
    {
        readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<ApplicationUser> GetUser(string id)
        {
            try
            {
                var user = await _dbContext.Users
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (user != null)
                {
                    return user;
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
