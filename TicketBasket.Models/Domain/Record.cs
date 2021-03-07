using System;
using System.ComponentModel.DataAnnotations;

namespace TicketBasket.Models.Domain
{
    public class Record
    {
        public Record()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
    }
}
