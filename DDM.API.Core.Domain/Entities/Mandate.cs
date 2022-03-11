
using DDM.API.Core.Domain.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DDM.API.Core.Domain.Helpers.EnumList;

namespace DDM.API.Core.Domain.Entities
{
    public class Mandate : AuditableBaseEntity
    {
        public long MerchantId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? ReferenceNumber { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? DrAccountNumber { get; set; }
        public DateTime? DueDate { get; set; } = null;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? RawData { get; set; }
        public PaymentFrequency? PaymentFrequency { get; set; }      //1=Monthly, 2=Quarterly, 3=BiAnnual, 4=Yearly
        public int? PaymentCount { get; set; }      //4, or 3 based on PaymentFrequency

        [DefaultValue(false)]
        public bool? IsApproved { get; set; }

        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? RequestedBy { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        [DefaultValue(false)]
        public bool? IsCancelled { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string? CancellationNote { get; set; }
        public string? CancellationBy { get; set; }
        public DateTime? CancellationDate { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant? Merchant { get; set; }
        public virtual TransactionLog? TransactionLog { get; set; }
        public virtual ICollection<MandateDetail>? MandateDetails { get; set; }
    }
}
