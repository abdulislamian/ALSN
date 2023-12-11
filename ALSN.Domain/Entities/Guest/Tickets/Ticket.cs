using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALSN.Application.Common.Utility.SD;

namespace ALSN.Domain.Entities.Guest.Tickets
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation props
        [ForeignKey("Guest")]
        public string GuestId { get; set; }
        public Guest Guest { get; set; }
    }
}
