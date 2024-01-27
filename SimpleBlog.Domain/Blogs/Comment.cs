namespace SimpleBlog.Domain.Blogs;

public class Comment
{
    public Comment(string fullName,string text,int postId)
    {
        FullName = fullName;
        Text = text;
        PostId = postId;
    }
    public int Id { get;private set; }
    public string FullName { get; set; }
    public string Text { get; set; }
    public int PostId { get; set; }
}
