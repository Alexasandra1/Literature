using Literature.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Literature.Database.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
//using System.Reflection.Emit;

namespace Literature.Database
{
    public class ApplicationDbContext : IdentityDbContext
        <
            User,
            IdentityRole,
            string,
            IdentityUserClaim<string>,
            UserRole,
            IdentityUserLogin<string>,
            IdentityRoleClaim<string>,
            IdentityUserToken<string>
        >
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<New> News { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Discussion> Discussions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");

            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(e => e.UserId);
            });

            builder.Entity<IdentityUserToken<string>>(b =>
            {
                b.HasKey(e => e.UserId);
            });

            builder.Entity<UserRole>(b =>
            {
                b.HasKey(e => new { e.UserId, e.RoleId });

                b.HasOne(e => e.Role)
                    .WithMany()
                    .HasForeignKey(e => e.RoleId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(e => e.User)
                    .WithMany(x => x.Roles)
                    .HasForeignKey(e => e.UserId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
            });

            //builder.Entity<Discussion>(b =>
            //{
            //    b.HasMany<Answer>(x => x.Answers)
            //    .WithOne(x => x.Discussion)
            //    .HasForeignKey(x => x.AnswerId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});
        }
    }
}