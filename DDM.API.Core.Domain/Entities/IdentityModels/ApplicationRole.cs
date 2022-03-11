using Microsoft.AspNetCore.Identity;

namespace DDM.API.Core.Domain.Entities.IdentityModels
{
    public class ApplicationRole : IdentityRole<long>
    {
        public ICollection<ApplicationUserRole>? UserRoles { get; set; }
    }
}
