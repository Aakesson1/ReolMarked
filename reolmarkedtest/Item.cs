using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reolmarkedtest
{
    public class Item
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }

        public static void items()
        {
            foreach (Item all in App.DataBase.items)
            {
                Console.WriteLine("{0})    {1}     {2},-", all.Id, all.Name, all.Price);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine();

            //Saving choice to x
            int x = int.Parse(Console.ReadLine()) - 1;
            App.Cart.cart.Add(App.DataBase.items[x]);

            Console.WriteLine("");
        }
    }
}
