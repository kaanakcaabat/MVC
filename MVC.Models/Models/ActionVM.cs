using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCRole.Options.Models.VM
{
    public class ActionVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }

        public int Controller { get; set; }

        public List<Entity.Options.Controller> Controllers{ get; set; }
        
      
    }
}