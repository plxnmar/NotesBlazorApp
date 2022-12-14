using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NotesBlazorApp.Shared;
using static Duende.IdentityServer.Models.IdentityResources;

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


            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasData(
                    new ApplicationUser
                    {
                        Id = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                        UserName = "user1234@mail.ru",
                        NormalizedUserName = "USER1234@MAIL.RU",
                        Email = "user1234@mail.ru",
                        NormalizedEmail = "USER1234@MAIL.RU",
                        EmailConfirmed = true,
                        PasswordHash = "AQAAAAEAACcQAAAAEJq5wyP9ng11WdDPgSl3qdH+5qLvQi88nuYM/hS0b7+HoHky+POzcZnFLK+TAYK42Q==",
                        SecurityStamp = "73NY4ALQX5ZVOAEBOYANZNXERLYLLSJD",
                        ConcurrencyStamp = "2b539445-1d12-4d62-8f73-c63feaea15e7",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnabled = true
                    });
            });

            builder.Entity<Note>(entity =>
            {
                entity.HasData(
                    new Note
                    {
                        Id = 1,
                        UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                        Title = "Note #1",
                        Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Faucibus scelerisque eleifend donec pretium. Turpis egestas maecenas pharetra convallis posuere morbi leo. ",
                        ChangedDate = DateTime.Now,
                        CreatedDate = DateTime.Now,
                        ColorCardId = 2,
                    },
                new Note
                {
                    Id = 2,
                    UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                    Title = "Note #2",
                    Details = "Nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit amet. Est ante in nibh mauris cursus mattis molestie a iaculis. Netus et malesuada fames ac turpis egestas maecenas pharetra. \r\n\r\nUt venenatis tellus in metus vulputate eu scelerisque felis. Purus ut faucibus pulvinar elementum integer enim neque volutpat. Rutrum tellus pellentesque eu tincidunt tortor aliquam.",
                    ChangedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ColorCardId = 1,
                },
                new Note
                {
                    Id = 3,
                    UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                    Title = "Note #3",
                    Details = "Rutrum tellus pellentesque eu tincidunt tortor aliquam.",
                    ChangedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ColorCardId = 4,
                },
                new Note
                {
                    Id = 4,
                    UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                    Title = "Note #4",
                    Details = "Donec ultrices tincidunt arcu non sodales neque sodales. Ultrices eros in cursus turpis massa. Nulla facilisi nullam vehicula ipsum. \r\n\r\nVitae semper quis lectus nulla at volutpat diam ut venenatis. Tellus in metus vulputate eu scelerisque felis imperdiet proin fermentum. Ullamcorper sit amet risus nullam eget felis. \r\n\r\nProin libero nunc consequat interdum varius sit amet. Sed arcu non odio euismod lacinia at quis. Faucibus a pellentesque sit amet. Urna neque viverra justo nec ultrices dui sapien eget mi. ",
                    ChangedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ColorCardId = 5,
                },
                new Note
                {
                    Id = 5,
                    UserId = "e6ffc017-69c2-4f55-9552-9563a2cde1da",
                    Title = "Note #5",
                    Details = "Aut iste quod sed repellendus dolor eos quaerat dolores At voluptas voluptatem ea iste cupiditate. Non ipsam dignissimos et eius quia et eligendi quis.",
                    ChangedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    ColorCardId = 3,
                });
            });

            base.OnModelCreating(builder);
        }
    }
}