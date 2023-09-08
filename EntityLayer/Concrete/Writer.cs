using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;
public class Writer
{
    [Key]
    public int WriterID { get; set; }
    public string WriterName { get; set; } = string.Empty;
    public string WriterAbout { get; set; } = string.Empty;
    public string WriterImage { get; set; } = string.Empty;
    public string WriterMail { get; set; } = string.Empty;
    public string WriterPassword { get; set; } = string.Empty;
    public bool WriterStatus { get; set; }
    public List<Blog>? Blogs { get; set; }
    public virtual ICollection<Message2> WriterSender { get; set; }
    public virtual ICollection<Message2> WriterReceiver { get; set; }
}
