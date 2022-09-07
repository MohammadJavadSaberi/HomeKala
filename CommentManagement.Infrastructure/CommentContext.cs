using CommentManagement.Domain.CommentAgg;
using CommentManagement.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CommentManagement.Infrastructure
{
    public class CommentContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public CommentContext(DbContextOptions<CommentContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mappingAssembly = typeof(CommentMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(mappingAssembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
