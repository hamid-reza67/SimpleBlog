namespace SimpleBlog.Features.Posts.EditPosts;


public record Response
{
    public int Id { get; init; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
}