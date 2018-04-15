using MVC.Core.Entity;
using MVC.Core.Enum;
using System;

namespace MVC.Core.Entity
{
    public class EntityBase : IEntity
    {
        public EntityBase()
        {
            Status = Status.Active;
        }


        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedIP { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedADUsername { get; set; }
        public int AutoID { get; set; }

    }
}
