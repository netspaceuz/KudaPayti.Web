using kudapoyti.Domain.Common;
using kudapoyti.Domain.Enums;

namespace kudapoyti.Domain.Entities.Admins
{
    public class Admin1 : BaseEntity
    {
        public string FullName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public string TelegramLink { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public string PasswordHash { get; set; } = String.Empty;

        public string Salt { get; set; } = String.Empty;

        public Role Role { get; set; }
    }
}
