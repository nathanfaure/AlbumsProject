

using AlbumsProject.BLL.Entities;
using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.DAL.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlbumsProject.DAL.EF
{
    public class BlogDbContext : IdentityDbContext<User, Role, int>
    {
        private readonly DatabaseOptions _dbOptions;
        public BlogDbContext(DbContextOptions<BlogDbContext> options, DatabaseOptions dbOptions)
            : base(options)
        {
            _dbOptions = dbOptions;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbOptions.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<User>().HasMany(c => c.Comments).WithOne(a => a.Author).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<ChatGroupToUsers>()
                .HasKey(t => new { t.ChatGroupId, t.UserId });


            builder.Entity<ChatGroupToUsers>()
                .HasOne(bc => bc.ChatGroup)
                .WithMany(b => b.ChatGroupToUsers)
                .HasForeignKey(bc => bc.ChatGroupId);

            builder.Entity<ChatGroupToUsers>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.ChatGroupToUsers)
                .HasForeignKey(bc => bc.UserId);

            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<ChatGroup> ChatGroups { get; set; }
    }
}
