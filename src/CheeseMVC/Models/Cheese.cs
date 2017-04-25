using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        IList<CheeseMenu> CheeseMenus { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }
    }
}
