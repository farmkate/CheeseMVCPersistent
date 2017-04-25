using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Menu
    {
        IEnumerable<CheeseMenu> CheeseMenus { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }

    }
}
