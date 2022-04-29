using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class BTUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [Display(Name = "Company Id")]
        public int? CompanyId { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile AvatarFormFile { get; set; }
        
        [Display(Name = "Avatar")]
        public string AvatarFileName { get; set; }
        public byte[] AvatarFileData { get; set; }

        [Display(Name = "File Extension")]
        public string AvatarContentType { get; set; }

        // Navigation Property
        public virtual Company Company { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}
