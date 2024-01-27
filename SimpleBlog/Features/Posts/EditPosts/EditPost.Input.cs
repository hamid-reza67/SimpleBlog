namespace SimpleBlog.Features.Posts.EditPosts;


public record Input{
    public int Id { get; init; }
    public string Title { get; init; }=default!;
    public string Content { get; init; }=default!;
}