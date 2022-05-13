using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1
{


    public delegate void splashScreenDelegate(int time);
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();


            splashScreenDelegate scd = (time) => {
                Console.WriteLine("Loading . . . ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                for (int i = time; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }


                Console.WriteLine("\n\n\t==================================================");
                Console.WriteLine("\t||\tWelcome to your Budget Planner    \t||");
                Console.WriteLine("\t==================================================\n\n");
                //Console.ReadLine();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            };

            scd.Invoke(5);
            acc.GetInput();


            Console.ReadLine();
        }
    }
}
