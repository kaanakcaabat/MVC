using MVC.Core.Entity;
using System.Collections.Generic;

namespace MVC.Entity.Options
{
    public class Role:EntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public virtual List<RoleAction> RoleActions { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
