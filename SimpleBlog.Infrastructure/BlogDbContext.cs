using Microsoft.EntityFrameworkCore;
using SimpleBlog.Domain.Blogs;

namespace SimpleBlog.Infrastructure;

public class BlogDbContext : DbContext
{
	public BlogDbContext(DbContextOptions<BlogDbContext> options)
		: base(options)
	{

	}

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
