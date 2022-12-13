using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NotesBlazorApp.Shared;

namespace NotesBlazorApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<ColorCard> ColorCards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Note>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasIndex(note => note.Id).IsUnique();
                entity.Property(note => note.Title).HasMaxLength(200);
                entity.HasOne(note => note.ColorCard)
                    .WithMany(c => c.Notes)
                    .HasForeignKey(u => u.ColorCardId);
            });

            builder.Entity<ColorCard>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasIndex(color => color.Id).IsUnique();
                entity.Property(color => color.Name).HasMaxLength(6);
                entity.Property(color => color.Description).HasMaxLength(50);
            });

            builder.Entity<ColorCard>(entity =>
            {
                entity.HasData(
                    new ColorCard { Id = 1, Name = "FFFFFF", Description = "White" },
                    new ColorCard { Id = 2, Name = "FC6471", Description = "Red" },
                    new ColorCard { Id = 3, Name = "FFD275", Description = "Yellow" },
                    new ColorCard { Id = 4, Name = "A1E5AB", Description = "Green Celadon" },
                    new ColorCard { Id = 5, Name = "B2ABF2", Description = "Blue Purple" }
                    );
            });

            base.OnModelCreating(builder);

        }
    }
}