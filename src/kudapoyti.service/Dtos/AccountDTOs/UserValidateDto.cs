using kudapoyti.Domain.Entities.Admins;
using kudapoyti.Domain.Enums;
using kudapoyti.Service.Common.Attributes;
using System.ComponentModel.DataAnnotations;


namespace kudapoyti.Service.Dtos.AccountDTOs
{
    public class UserValidateDto
    {
        [StrongEmail]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        public static implicit operator Admin1(UserValidateDto dto)
        {
            return new Admin1()
            {
                Id = 0,
                Email = dto.Email,
                FullName = dto.Name,
                Role = Role.User,
            };
        }
    }
}
