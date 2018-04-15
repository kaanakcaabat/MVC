using MVC.Core.Entity;
using System;

namespace MVC.Entity.Options
{
    public class RoleAction:EntityBase
    {
        public int RoleId { get; set; }

        public int ActionId { get; set; }


        public virtual Role Role { get; set; }

        public virtual Action Action { get; set; }
    }
}
