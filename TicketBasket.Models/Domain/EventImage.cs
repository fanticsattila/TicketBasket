﻿using System.ComponentModel.DataAnnotations;

namespace TicketBasket.Models.Domain
{
    public class EventImage : Record
    {
        [Required]
        [StringLength(256)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(256)]
        public string ThumbUrl { get; set; }

        public virtual Event Event { get; set; }
        public string EventId { get; set; }
    }
}
