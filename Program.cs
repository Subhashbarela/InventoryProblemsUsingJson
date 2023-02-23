using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\InventoryManagement\\InventoryManagement\\Inventory.json";
            FetchInventory fetchInventory = new FetchInventory();

            InventoryDetails data = fetchInventory.Read(path);
            Console.WriteLine("Types Of Rice");
            Console.WriteLine("**************************\n");
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);

                int price = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfRice[i].name, data.typesOfRice[i].weight, price);
            }

            Console.WriteLine("\n............................\n");
            Console.WriteLine("Types Of Pulses");
            Console.WriteLine("**************************\n");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);

                int price = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfPulses[i].name, data.typesOfPulses[i].weight, price);
            }

            Console.WriteLine("\n............................\n");
            Console.WriteLine("Types Of Wheat");
            Console.WriteLine("**************************\n");

            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);

                int price = data.typesOfWheat[i].weight * data.typesOfWheat[i].price;
                Console.WriteLine("The price of {0} for {1}kg is {2}", data.typesOfWheat[i].name, data.typesOfWheat[i].weight, price);

            }

        }
    }
}
