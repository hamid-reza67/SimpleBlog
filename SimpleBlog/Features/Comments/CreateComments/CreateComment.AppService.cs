

using SimpleBlog.Domain.Blogs;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Features.Comments.CreateComments;

public class AppService
{
    private readonly BlogDbContext _dbContext;

    public AppService(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Handler(Input input)
    {
        var comment = new Comment(input.FullName,input.Text,input.PostId);
        _dbContext.Comments.Add(comment);
        await _dbContext.SaveChangesAsync();
        return comment.Id;
    }
}
