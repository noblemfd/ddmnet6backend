using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DDM.API.Core.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual long Id { get; set; }
    }
}
