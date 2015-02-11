using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Inventory
    {
        private Item[] items = new Item[100];
        private int activeItems = 0;

        public void Add()
        {
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
        }

        public void Change()
        {
            Console.WriteLine("Change Item");
            // Ask for the item#
            // Check if it exists in the items[]
            // If you find it then ask for everything except item#
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
            // Ask for the item#
            // Check if it exists
            // If you find it, shift the array
        }

        public void ListAll()
        {
            Console.WriteLine("List All");

            for (var i = 0; i < activeItems; i++)
            {
                Console.WriteLine("{0} {1}",
                    items[i].ItemNumber,
                    items[i].Description);
            }

        }

        public void ListAllBelow()
        {
            Console.WriteLine("List All Below");
            // Ask for a quantity
            // Display all items that have a quantity less than that
        }
    }
}
