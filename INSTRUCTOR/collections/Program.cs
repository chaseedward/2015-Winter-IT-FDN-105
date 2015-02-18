using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public struct InventoryItem
    {
        public int ItemNumber { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var list = new List<InventoryItem>();

            list.Add(new InventoryItem
            {
                ItemNumber = 101,
                Name = "apples",
                Price = .25f,
            });

            list.Add(new InventoryItem
            {
                ItemNumber = 201,
                Name="cherries",
                Price = .10f,
            });

            list.RemoveAll(t => t.ItemNumber == 201);
            // This is what RemoveAll is doing:
            //foreach (var t in list)
            //{
            //    if (t.ItemNumber == 201)
            //    {
            //        // remove it
            //    }
            //}

            var dictionary = new Dictionary<int, InventoryItem>();

            dictionary[101] = new InventoryItem
            {
                ItemNumber = 101,
                Name = "apples",
                Price = .25f,
            };

            //dictionary.Add(101, new InventoryItem
            //{
            //    ItemNumber = 101,
            //    Name = "apples",
            //    Price = .25f,
            //});

            //dictionary.Add(201, new InventoryItem
            //{
            //    ItemNumber = 201,
            //    Name = "cherries",
            //    Price = .10f,
            //});

            // duplicate key so exception is thrown
            dictionary.Add(101, new InventoryItem());
        }
    }
}
