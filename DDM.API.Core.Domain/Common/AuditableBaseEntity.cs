using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace DDM.API.Core.Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        public virtual long Id { get; set; }
        public string? CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }

        public string? LastUpdatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LastUpdatedDate { get; set; }

        [JsonIgnore]
        public bool? IsDeleted { get; set; }
    }
}
