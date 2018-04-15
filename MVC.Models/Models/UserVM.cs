
using System;
using System.ComponentModel.DataAnnotations;

namespace BA.BAse.WebUI.Areas.Options.Models.VM
{
    public class UserVM
    {
        public int Id { get; set; }
        [Required]
        public string ADUsername { get; set; }
        [Required]
        public int Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobilePhoneNumber { get; set; }
    
        [Required]
        public bool IsQuantityApprove { get; set; }
         
    }
}