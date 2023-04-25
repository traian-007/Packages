using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Packages.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; private set; }

        public BaseEntity()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}
