namespace SimpleBlog.Features.Comments.GetCommentsByPostIds;

public class Response
{
    public int Id { get; init; }
    public string FullName { get; init; } = default!;
    public string Text { get; init; } = default!;
    public int PostId { get; init; }

}
