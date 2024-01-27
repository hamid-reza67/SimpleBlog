namespace SimpleBlog.Domain.Blogs;

public class Post
{
    public Post(string title, string content)
    {
        Title = title;
        Content = content;
        Active = false;
    }
    public int Id { get; private set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public bool Active { get; set; }
    public List<Comment> Comments { get; set; } = new();
}
