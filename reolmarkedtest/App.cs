using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reolmarkedtest
{

    class App
    {
        
        public static class DataBase
        {
            public static List<Item> items { get; set; }

            static DataBase()
            {
                items = new List<Item>();
            }
        }
        public static class Cart
        {
            public static List<Item> cart { get; set; }

            static Cart()
            {
                cart = new List<Item>();
            }
        }
        public static void start()
        {
                
            Console.WriteLine("1 - Vis alle varer");
            Console.WriteLine("2 - Vis alle valgte varer");
            Console.WriteLine("3 - Tilføj varer");
            Console.WriteLine("0 - Afslut");
            Console.Write("Angiv dit valg: ");

           
        }
        public static void Text()
        {
            Console.Clear();
            Console.WriteLine("Our database contains {0} items", DataBase.items.Count);
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("ID      item name");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
        }
        public static void NewItem()
        {
            TextWriter tsw = new StreamWriter(@"C:\Users\MIke\Desktop\Opgaver\items.txt", true);

            //Writing text to the file.
            Console.WriteLine("Write in format id,item name,Price");
            tsw.WriteLine(Console.ReadLine());

            //Close the file.
            tsw.Close();
        }

        public static void ReadItem()
        {
            string[]? txt = File.ReadAllLines(@"C:\Users\MIke\Desktop\Opgaver\items.txt");

            foreach (string line in txt)
            {
                var whatever = line.Split(',');
                Item item = new Item();
                item.Id = Convert.ToInt32(whatever[0]);
                item.Name = whatever[1];
                item.Price = Convert.ToInt32(whatever[2]);
                App.DataBase.items.Add(item);
            }
        }
        public static void MainMenu()
        {
            App.ReadItem();
            bool repeat = true;
            Console.WriteLine("Dit kundenummer er ");
            Customer.UniqueID.uniqueID();
            Console.WriteLine("\n");
            do
            {
                App.start();
                switch (Console.ReadLine())
                {
                    case "1":
                        App.Text();
                        Item.items();
                        break;

                    case "2":
                        Customer.cart();
                        break;

                    case "3":
                        App.NewItem();
                        break;
                    case "0":
                        repeat = false;
                        break;

                }

            }
            while (repeat);
        }

    }


}
