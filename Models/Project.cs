using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class Project
    {
        // Primary Key
        public int Id { get; set; }
        
        // Foreign Key
        public int CompanyId { get; set; }
        
        [Required]
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTimeOffset EndDate { get; set; }

        [Display(Name = "Project Priority")]
        public int ProjectPriorityId { get; set; }

        [Display(Name = "File Date")]
        public DateTimeOffset Created { get; set; }

        [Display(Name = "File Description")]
        public string FileDescription { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        public byte[] FileData { get; set; }

        [Display(Name = "File Extension")]
        public string FileContentType { get; set; }

        [Display(Name = "Archived")]
        public bool Archived { get; set; }

        // Navigational Properties
        public virtual Company Company { get; set; }
        public virtual ProjectPriority ProjectPriority { get; set; }
        public virtual BTUser Members { get; set; }
        public Ticket Tickets { get; set; }

    }
}
