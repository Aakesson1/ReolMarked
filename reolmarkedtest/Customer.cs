using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reolmarkedtest
{
    internal class Customer
    {
        public class UniqueID
        {
            private static readonly int Uniqueid;

            static UniqueID()
            {
                Uniqueid = new Random().Next(1,9999999);
            }

            public static void uniqueID()
            {
                Console.WriteLine(Uniqueid);
            }
        }
       

        public static void cart()
        {
            List<int> parts = new List<int>();
            int sum = 0;
            int sum1 = 0;
            Console.Clear();
            foreach (Item all in App.Cart.cart)
            {

                Console.WriteLine("{0})    {1}     {2},-", all.Id, all.Name, all.Price);
                Console.WriteLine("-----------------------");

                sum = sum + all.Price;

            }
            Console.WriteLine("Total beløbet er {0},- \n", sum);

            Console.WriteLine("Dit kundenummer er ");
            UniqueID.uniqueID();
            Console.WriteLine("\n");


        }



    }

}
