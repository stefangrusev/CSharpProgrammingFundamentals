using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] boxProperties = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Item item = new Item()
                {
                    Name = boxProperties[1],
                    Price = decimal.Parse(boxProperties[3])
                };
                Box box = new Box()
                {
                    SerialNumber = boxProperties[0],
                    Item = item,
                    Quantity = double.Parse(boxProperties[2]),
                    BoxPrice = item.Price * decimal.Parse(boxProperties[2])
                };

                boxes.Add(box);
                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public double Quantity { get; set; }
        public decimal BoxPrice { get; set; }
    }
}
