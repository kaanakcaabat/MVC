using MVC.Core.Entity;
using System.Collections.Generic;

namespace MVC.Entity.Options
{
    public class Menu : EntityBase
    {
        public Menu()
        {         
             this.Menus = new List<Menu>();         
        }
        public string Code { get; set; }
        public string Name { get; set; }

        public int? ParentMenuId { get; set; }
        public int? ActionID { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int OrderIndex { get; set; }

        public virtual Menu ParentMenu { get; set; }
        public List<Menu> Menus { get; set; } 
        public virtual Action Action { get; set; }

    }
}
