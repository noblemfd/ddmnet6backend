using DDM.API.Core.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDM.API.Core.Domain.Entities
{
    public class TransactionLog : AuditableBaseEntity
    {
        [ForeignKey("MerchantId")]
        public long? MerchantId { get; set; }

        [ForeignKey("Mandate")]
        public long? MandateId { get; set; }
        public string? RawData { get; set; }
        public virtual Mandate? Mandate { get; set; }
        public virtual Merchant? Merchant { get; set; }
    }
}
