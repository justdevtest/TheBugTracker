using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models.ViewModels
{
    public class ManageUserRolesViewModel
    {
        // Responsible for moving data within the MVC structure for this feature
        public BTUser BTUser { get; set; }
        public MultiSelectList Roles { get; set; }
        public List<String> SelectedRoles { get; set; }
    }
}
