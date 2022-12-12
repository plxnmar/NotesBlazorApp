using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NotesBlazorApp.Server.Models;

namespace NotesBlazorApp.Server.Data
{
    public class ApplicationUsersDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationUsersDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}