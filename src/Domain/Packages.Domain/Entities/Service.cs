using Packages.Domain.Entities.Base;
using System.Net.Http.Json;

namespace Packages.Domain.Entities
{
    public class Service : BaseEntity
    {
        public JsonContent? Config { get; set; }
        public int? Type { get; set; }
        public string? Status { get; set; }
        public string? PaymentStatus { get; set; }
        public User? User { get; set; }
        public User? CreatedByUserId { get; set; }
    }
}
