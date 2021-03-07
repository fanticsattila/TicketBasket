using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBasket.Models.Domain
{
    public class Ticket : Record
    {
        public Ticket()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Required]
        [StringLength(14)]
        public string BarCode { get; set; }
        
        public int? Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalPrice { get; set; }

        public string Place { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual Event Event { get; set; }
        public string EventId { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        public string UserProfileId { get; set; }

    }
}
