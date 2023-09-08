using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models;

public class UserSignInViewModel
{
    [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
    public string username { get; set; }
    [Required(ErrorMessage = "Lütfen şifre giriniz")]
    public string password { get; set; }
}
