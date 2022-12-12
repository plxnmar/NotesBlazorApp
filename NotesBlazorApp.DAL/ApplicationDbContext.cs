using Microsoft.EntityFrameworkCore;
using NotesBlazorApp.Domain.Entities;

namespace NotesBlazorApp.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
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
            });

            base.OnModelCreating(builder);

        }
    }
}