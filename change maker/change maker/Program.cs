using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_maker
{
    class Program
    {
        static void Main(string[] args)
        { // to show the work of the fuction.
            Console.WriteLine("3.18-");
            ChangeMaker(3.18);
            Console.WriteLine("0.99-");
            ChangeMaker(0.99);
            Console.WriteLine("12.93-");
            ChangeMaker(12.93);



            Console.ReadKey(); //to keep the console open.
        }
        static void ChangeMaker(double amount) // a fuction.
        {
            int quart = 0;
            int dime = 0;
            int nick = 0;
            int pen = 1; //<- can't complete it when it's 0, add a 1 to it.
            while (amount >= 0.25) // use while loops to make the value of the coins.
            {
                amount -= 0.25;
                quart++;
            }
            while (amount >= 0.10)
            {
                amount -= 0.10;
                dime++;
            }
            while (amount >= 0.05)
            {
                amount -= 0.05;
                nick++;
            }
            while (amount >= 0.01)
            {
                amount -= 0.01;
                pen++;
            }// for Writing it so it can work.
            Console.WriteLine("quarters: "+quart);
            Console.WriteLine("dimes: " + dime);
            Console.WriteLine("nickels: " + nick);
            Console.WriteLine("pennys: " + pen);
        }
    }
}
