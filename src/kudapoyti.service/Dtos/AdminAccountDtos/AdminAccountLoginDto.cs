using kudapoyti.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace kudapoyti.Service.Dtos.Accounts;

public class AdminAccountLoginDto
{
    [Required(ErrorMessage = "Cerate Email")]
    [EmailAddress(ErrorMessage = "Worning Email")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Create Password!!!")]
    [StrongPasswordAttribute]
    public string Password { get; set; } = string.Empty;
}
