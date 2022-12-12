using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUser(string id);
   
    }
}
