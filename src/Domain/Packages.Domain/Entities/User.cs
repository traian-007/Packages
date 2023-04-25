using Packages.Domain.Entities.Base;

namespace Packages.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Type { get; set; }
        public Contact? Contact { get; set; }
        public string? ContactId { get; set; }
    }
}
