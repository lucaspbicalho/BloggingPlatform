public class BlogPost
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<Comment> Comments { get; set; }
}