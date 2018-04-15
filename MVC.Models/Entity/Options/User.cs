using MVC.Core.Entity;
using System;

namespace MVC.Entity
{

    public class User : EntityBase
    {
        public string ADUsername { get; set; }

        public int TitleId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string MobilePhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        public bool IsQuantityApprove { get; set; }
 
    }
}
