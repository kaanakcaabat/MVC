using MVC.Core.Entity;
using System.Collections.Generic;


namespace MVC.Entity.Options
{
    public class Controller:EntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public virtual List<Action> Actions { get; set; }
    }
}
