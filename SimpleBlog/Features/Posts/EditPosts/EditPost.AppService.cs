using System.Data;
using Dapper;
using SimpleBlog.Infrastructure;



namespace SimpleBlog.Features.Posts.EditPosts;

public class AppService
{
    private readonly BlogDbContext _dbContext;

    public AppService(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task Handler(Input input)
    {
        var post = await _dbContext.Posts.FindAsync(input.Id) ?? throw new Exception("Not found!");

        post.Title = input.Title;
        post.Content = input.Content;
        _dbContext.Update(post);
        await _dbContext.SaveChangesAsync();
    }
}