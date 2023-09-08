using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;
public class Blog
{
    [Key]
    public int BlogID { get; set; }
    public string BlogTitle { get; set; } = string.Empty;
    public string BlogContent { get; set; } = string.Empty;
    public string BlogThumbnailImage { get; set; } = string.Empty;
    public string BlogImage { get; set; } = string.Empty;
    public DateTime BlogCreateDate { get; set; }
    public bool BlogStatus { get; set; }
    public int CategoryID { get; set; }
    public Category? Category { get; set; }
    public int WriterID { get; set; }
    public Writer? Writer { get; set; }
    public List<Comment>? Comments { get; set; }
}
