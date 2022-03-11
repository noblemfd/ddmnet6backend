using DDM.API.Core.Domain.Entities.IdentityModels;
using DDM.API.Core.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDM.API.Core.Domain.Entities
{
    public class MerchantUser : AuditableBaseEntity
    {
        public long MerchantId { get; set; }
        public long UserId { get; set; }
        public bool? IsMerchantAdmin { get; set; }
        //public string UserName { get; set; }
        public virtual ApplicationUser? User { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchant? Merchant { get; set; }
    }
}
