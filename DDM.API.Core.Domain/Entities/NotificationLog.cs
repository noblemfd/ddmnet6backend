using DDM.API.Core.Domain.Common;
using System.ComponentModel;
using static DDM.API.Core.Domain.Helpers.EnumList;

namespace DDM.API.Core.Domain.Entities
{
    public class NotificationLog : AuditableBaseEntity
    {
        public string? NotificationDetail { get; set; }
        public NotificationResponse? NotificationResponse { get; set; }     // None = 0, Rejected = 1, Accepted = 2
        public NotificationType? NotificationType { get; set; }     // None = 0, Merchant = 1, Customere = 2
        public string? SentTo { get; set; }

        [DefaultValue(false)]
        public bool? IsRead { get; set; }
    }
}
