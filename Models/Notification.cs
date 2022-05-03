using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class Notification
    {
        // Primary Key
        public int Id { get; set; }

        // Foriegn Key
        [Display(Name = "Ticket")]
        public int TicketId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTimeOffset Created { get; set; }

        [Required]
        [Display(Name = "Recipient")]
        public string RecipientId { get; set; }

        [Required]
        [Display(Name = "Sender")]
        public string SenderId { get; set; }

        [Required]
        [Display(Name = "Read")]
        public bool Viewed { get; set; }

        // Navigation Properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser Recipient { get; set; }
        public virtual BTUser Sender { get; set; }

    }
}
