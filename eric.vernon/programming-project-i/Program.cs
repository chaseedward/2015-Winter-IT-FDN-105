//Eric Vernon
using System;

namespace programming_project_i
{
    struct Item
    {
        public int ItemNumber;
        public string Description;
        public float Price;
        public int Quantity;
        public float Cost;
        public float Value;
    }

    class Program
    {
        static void Main()
        {
            var items = new Item[100];
            int activeItems = 0;

            var menuItems = new[]
            {
                "Add an item",
                "Change an item (by giving its item number)",
                "Delete an item (by giving its item number)",
                "List all items in the database",
                "List items below a user-given quantity (for re-ordering purposes)",
                "Quit",
            };

            var quitting = false;

            while (!quitting)
            {
                int menuItemNumber = 1;
                foreach (string menuItem in menuItems)
                {
                    Console.WriteLine("{0}. {1}", menuItemNumber++, menuItem);
                }

                Console.Write("Choose menu item: ");
                var menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine("Add Item");

                        Console.Write("Item#       :");
                        var itemNumber = Console.ReadLine();

                        Console.Write("Description :");
                        var description = Console.ReadLine();

                        Console.Write("Price       :");
                        var price = Console.ReadLine();

                        Console.Write("Quantity    :");
                        var quantity = Console.ReadLine();

                        Console.Write("Cost        :");
                        var cost = Console.ReadLine();

                        items[activeItems].ItemNumber = int.Parse(itemNumber);
                        items[activeItems].Description = description;
                        items[activeItems].Price = float.Parse(price);
                        items[activeItems].Quantity = int.Parse(quantity);
                        items[activeItems].Cost = float.Parse(cost);
                        activeItems++;

                        break;
                    case "2":
                        Console.WriteLine("Change Item");
                        // Ask for the item#
                        // Check if it exists in the items[]
                        // If you find it then ask for everything except item#
                        break;
                    case "3":
                        Console.WriteLine("Delete");
                        // Ask for the item#
                        // Check if it exists
                        // If you find it, shift the array
                        break;
                    case "4":
                        Console.WriteLine("List All");

                        for (var i = 0; i < activeItems; i++)
                        {
                            Console.WriteLine("{0} {1}",
                                items[i].ItemNumber,
                                items[i].Description);
                        }

                        break;
                    case "5":
                        Console.WriteLine("List All Below");
                        // Ask for a quantity
                        // Display all items that have a quantity less than that
                        break;
                    case "6":
                        Console.WriteLine("Quit");
                        quitting = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
