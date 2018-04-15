using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCRole.Options.Models
{
    public class RoleVM
    {
        public int Id { get; set; }

        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Entity.Options.Action> Actions { get; set; } 
        public List<Entity.Options.Controller> Controllers { get; set; }
        public List<Entity.Options.RoleAction> RoleActions { get; set; }
    }
}