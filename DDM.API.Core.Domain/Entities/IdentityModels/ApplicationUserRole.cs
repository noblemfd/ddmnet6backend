using Microsoft.AspNetCore.Identity;

namespace DDM.API.Core.Domain.Entities.IdentityModels
{
    public class ApplicationUserRole : IdentityUserRole<long>
    {
        public virtual ApplicationUser? User { get; set; }
        public virtual ApplicationRole? Role { get; set; }
    }
}
