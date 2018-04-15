using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCRole.Options.Models.VM
{
    public class ControllerVM
    {
        public int Id { get; set; }

        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
         [Required]
        public string Title { get; set; }

    }
}