using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class Ticket
    {
        // Primary Key
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated")]
        public DateTimeOffset? Updated { get; set; }

        [Display(Name = "Archived")]
        public bool Archived { get; set; }
        
        // Added new property after db migration
        // Must update the database to match
        //// 1. add-migration "name"
        //// 2. update-database
        [Display(Name = "Archived By Project")]
        public bool ArchivedByProject { get; set; }

        // Foreign Keys
        [Display(Name = "Project")]
        public int ProjectId { get; set; }

        [Display(Name = "Ticket Type")]
        public int TicketTypeId { get; set; }

        [Display(Name = "Ticket Priority")]
        public int TicketPriorityId { get; set; }

        [Display(Name = "Ticket Status")]
        public int TicketStatusId { get; set; }

        [Display(Name = "Ticket Owner")]
        public string OwnerUserId { get; set; }

        [Display(Name = "Ticket Developer")]
        public string DeveloperUserId { get; set; }

        // Navigational Properties
        public virtual BTUser OwnerUser { get; set; }
        public virtual BTUser DeveloperUser { get; set; }
        public virtual TicketType TicketType { get; set; }
        public virtual TicketPriority TicketPriority { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }
        public virtual Project Project { get; set; }

        public virtual ICollection<TicketComment> Comments { get; set; } = new HashSet<TicketComment>();
        public virtual ICollection<TicketAttachment> Attachments { get; set; } = new HashSet<TicketAttachment>();
        public virtual ICollection<TicketHistory> History { get; set; } = new HashSet<TicketHistory>();
        public virtual ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
    }
}
