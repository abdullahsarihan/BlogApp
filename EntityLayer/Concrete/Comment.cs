using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;
public class Comment
{
    [Key]
    public int CommentID { get; set; }
    public string CommentUserName { get; set; } = string.Empty;
    public string CommentTitle { get; set; } = string.Empty;
    public string CommentContent { get; set; } = string.Empty;
    public DateTime CommentDate { get; set; }
    public int BlogScore { get; set; }
    public bool CommentStatus { get; set; }
    public int BlogID { get; set; }
    public Blog? Blog { get; set; }
}
