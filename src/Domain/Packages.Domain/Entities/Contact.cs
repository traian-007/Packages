using Packages.Domain.Entities.Base;

namespace Packages.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public TimeZoneInfo? TimeZone { get; set; }
    }
}
