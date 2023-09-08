using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete;

public class Category
{
    [Key]
    public int CategoryID { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryDescription { get; set; } = string.Empty;
    public bool CategoryStatus { get; set; }
    public List<Blog>? Blogs { get; set; }
}
