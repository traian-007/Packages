using Packages.Domain.Entities.Base;
using System.Net.Http.Json;

namespace Packages.Domain.Entities
{
    public class Package : BaseEntity
    {
        public string? ExternalId { get; set; }
        public string? Name { get; set; }
        public IEnumerable<string>? Features { get; set;}
        public int? Price { get; set; }
        public JsonContent? Meta { get; set; }
        public int? Status { get; set; }
    }
}
