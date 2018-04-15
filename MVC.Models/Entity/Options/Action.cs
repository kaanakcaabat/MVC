using MVC.Core.Entity;
using System.Collections.Generic;

namespace MVC.Entity.Options
{
    public class Action:EntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public int ControllerId { get; set; }

        public virtual Controller Controller { get; set; }

        public virtual List<RoleAction> RoleActions { get; set; }

        public virtual List<Menu> Menus { get; set; }
    }
}
