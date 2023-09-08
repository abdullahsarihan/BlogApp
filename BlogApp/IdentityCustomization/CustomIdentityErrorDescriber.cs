using Microsoft.AspNetCore.Identity;

namespace BlogApp.IdentityCustomization;

public class CustomIdentityErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
        {
            Code = nameof(PasswordTooShort),
            Description = $"Şifre en az {length} karakter uzunluğunda olmalıdır."
        };
    }

    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresNonAlphanumeric),
            Description = "Şifre en az bir alfanümerik olmayan karakter içermelidir."
        };
    }

    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresLower),
            Description = "Şifre en az bir küçük harf ('a'-'z') içermelidir."
        };
    }

    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresUpper),
            Description = "Şifre en az bir büyük harf ('A'-'Z') içermelidir."
        };
    }

    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresDigit),
            Description = "Şifre en az bir rakam içermelidir."
        };
    }
}
