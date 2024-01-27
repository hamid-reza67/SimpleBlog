namespace SimpleBlog.Features.Comments.CreateComments;

public record Input
{
    public string FullName { get; set; } = default!;
    public string Text { get; set; } = default!;
    public int PostId { get; set; }
}
