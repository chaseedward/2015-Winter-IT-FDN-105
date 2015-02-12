using System;
using common;

namespace programming_project_i
{
    class Program
    {
        static void Main()
        {
            var inventory = new Inventory();

            var menuItems = new[]
            {
                "Add an item",
                "Change an item (by giving its item number)",
                "Delete an item (by giving its item number)",
                "List all items in the database",
                "List items below a user-given quantity (for re-ordering purposes)",
                "Quit",
            };

            var menu = new Menu(menuItems);

            var quitting = false;

            while (!quitting)
            {
                menu.Display();

                var menuOption = menu.GetMenuOption();

                switch (menuOption)
                {
                    case "1":
                        inventory.Add();
                        break;
                    case "2":
                        inventory.Change();
                        break;
                    case "3":
                        inventory.Delete();
                        break;
                    case "4":
                        inventory.ListAll();
                        break;
                    case "5":
                        inventory.ListAllBelow();
                        break;
                    case "6":
                        Console.WriteLine("Quit");
                        quitting = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
