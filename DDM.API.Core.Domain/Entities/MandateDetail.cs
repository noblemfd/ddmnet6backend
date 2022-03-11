using DDM.API.Core.Domain.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DDM.API.Core.Domain.Helpers.EnumList;

namespace DDM.API.Core.Domain.Entities
{
    public class MandateDetail : AuditableBaseEntity
    {
        public long? MerchantId { get; set; }
        public long? MandateId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? ReferenceNumber { get; set; }
        public int? SerialNumber { get; set; }  //1,2,3 ... by MandateId
        public string? DrAccountNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Narration { get; set; }
        public MandateStatus MandateStatus { get; set; }    //Pending = 0, Failed = 1, Processed = 2

        [DefaultValue(false)]
        public bool? IsNotified { get; set; }

        [Display(Name = "Payable Amount")]
        [DataType(DataType.Currency)]
        public decimal? PayableAmount { get; set; }
        public string? PostingReference { get; set; }
        public string? ProcessedBy { get; set; }
        public DateTime ProcessedDate { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant? Merchant { get; set; }

        [ForeignKey("MandateId")]
        public virtual Mandate? Mandate { get; set; }
    }
}
