using SimpleBlog.Infrastructure;

namespace SimpleBlog.Features.Posts.DeletePosts;

public class AppService
{
    private readonly BlogDbContext _dbContext;

    public AppService(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Handler(int id)
    {
        var post = await _dbContext.Posts.FindAsync(id) ?? throw new Exception("Not found!");
        if (post.Active)
            throw new Exception("The post is Active!");

        _dbContext.Remove(post);
        await _dbContext.SaveChangesAsync();
    }
}
