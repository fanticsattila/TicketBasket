using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBasket.Models.Domain
{
    public class JobApplication : Record
    {
        public JobApplication()
        {
            ApplicationDate = DateTime.UtcNow;
        }

        public string Position { get; set; }
        public string Description { get; set; }
        public string CvUrl { get; set; }
        public JobApplicationStatusEnum Status { get; set; }

        public virtual UserProfile AppliedUser { get; set; }
        [ForeignKey(nameof(AppliedUser))]
        public string AppliedUserId { get; set; }

        public virtual UserProfile Organizer { get; set; }
        [ForeignKey(nameof(Organizer))]
        public string OrganizerId { get; set; }

        public DateTime ApplicationDate { get; set; }
    }
}
