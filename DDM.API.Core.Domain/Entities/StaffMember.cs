using DDM.API.Core.Domain.Entities.IdentityModels;
using DDM.API.Core.Domain.Common;
using System.ComponentModel;

namespace DDM.API.Core.Domain.Entities
{
    public class StaffMember : AuditableBaseEntity
    {
        public long? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        [DefaultValue(false)]
        public bool? IsAdmin { get; set; }
        public string? Description { get; set; }
        public string? BankBranch { get; set; }
        public string? HeadOffice { get; set; }
    }
}
