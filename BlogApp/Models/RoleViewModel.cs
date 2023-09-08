using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models;

public class RoleViewModel
{
    [Required(ErrorMessage = "Lütfen role adı giriniz")]
    public string name { get; set; }
}
