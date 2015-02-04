using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_project_i
{
    class Menu
    {
        private string[] _menuItems;

        public Menu(string[] menuItems)
        {
            _menuItems = menuItems;
        }

        public void Display()
        {
            int menuItemNumber = 1;
            foreach (string menuItem in _menuItems)
            {
                Console.WriteLine("{0}. {1}", menuItemNumber++, menuItem);
            }
        }

        public string GetMenuOption()
        {
            Console.Write("Choose menu item: ");
            var menuOption = Console.ReadLine();

            return menuOption;
        }
    }
}
