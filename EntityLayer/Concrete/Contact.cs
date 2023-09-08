using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;
public class Contact
{
    [Key]
    public int ContactID { get; set; }
    public string ContactUserName { get; set; } = string.Empty;
    public string ContactMail { get; set; } = string.Empty;
    public string ContactSubject { get; set; } = string.Empty;
    public string ContactMessage { get; set; } = string.Empty;
    public DateTime ContactDate { get; set; }
    public bool ContactStatus { get; set; }
}
