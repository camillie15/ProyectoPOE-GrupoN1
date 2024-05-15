using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // By: Mateo Aguilar Villafuerte
    internal class Menu
    {
        private List<MenuItem> menuItem = null;

        public Menu()
        {
            this.menuItem = new List<MenuItem>();
            menuItem.Add(new MenuItem(1, "Combo 1", "Hamburguesa, Papas, Cola", 4.99, true));
            menuItem.Add(new MenuItem(2, "Combo 2", "Nuggets, Papas, Cola", 3.99, true));
            menuItem.Add(new MenuItem(3, "Combo 3", "Arroz con Menestra y Pollo, Cola", 4.99, true));
        }

        public List<MenuItem> MenuItem { get => menuItem; set => menuItem = value; }

        public override string ToString()
        {
            return "Menu Items:\n" + string.Join("\n", menuItem);
        }
    }
}
