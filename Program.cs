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
            Console.WriteLine("Stock Marketing And Share Holder");
            Console.WriteLine("......................................\n");
            int totalStock = 0;
            for (int i = 0; i < data.typesOfStock.Count; i++)
            {
                Console.WriteLine(data.typesOfStock[i].name);
                Console.WriteLine(data.typesOfStock[i].numberOfShare);
                Console.WriteLine(data.typesOfStock[i].price);

                int price = data.typesOfStock[i].numberOfShare * data.typesOfStock[i].price;

                totalStock = totalStock + price;
                Console.WriteLine("The price of {1} shares of the {0} stock is : {2}", data.typesOfStock[i].name, data.typesOfStock[i].numberOfShare, price);
                Console.WriteLine("--------------------------------------------------\n");
            }

            Console.WriteLine("The total value of your stock is {0}", totalStock);
            Console.Read();

        }
    }
}
