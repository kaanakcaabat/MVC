using MVCRole.Entity;
using MVCRole.Entity.Options;
using System.Collections.Generic;

namespace BA.BAse.WebUI.Areas.Options.Models.VM
{
    public class UserRoleVM
    {
        public User User { get; set; }

        public List<Role> Roles { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}