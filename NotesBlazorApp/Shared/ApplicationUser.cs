using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace NotesBlazorApp.Shared
{
    public class ApplicationUser : IdentityUser
    {
        //public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        //{
        //    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //    return userIdentity;
        //}

        // Тут устанавливаем связь с нашей таблицей
        public virtual ICollection<Note> Notes { get; set; }

        public ApplicationUser()
        {
            Notes = new List<Note>();
        }
    }
}