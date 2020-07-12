using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC_UserManagementInterface.ViewModel
{
    public class EditUserViewModel
    {
        //public EditUserViewModel()
        //{
        //    Claims = new List<string>();
        //    Roles = new List<string>();
        //}
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
        public List<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
        public string Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //public string Roles { get; set; }

        //public List<string> Claims { get; set; }

        //public IList<string> Roles { get; set; }
    }
}
