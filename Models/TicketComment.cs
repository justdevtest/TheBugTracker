using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [Display(Name = "Ticket")]
        public int TicketId { get; set; }

        [Display(Name = "Team Member")]
        public string UserId { get; set; }

        [Display(Name = "Member Comment")]
        public string Comment { get; set; }

        [Display(Name = "Date")]
        public DateTimeOffset Created { get; set; }

        // Navigation Properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
