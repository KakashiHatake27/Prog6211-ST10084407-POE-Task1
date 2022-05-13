using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1
{


    public delegate void splashScreenDelegate(int time);
    public delegate void accountDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Creating a new instance of the Account class. */
            Account acc = new Account();


            /* A delegate that is used to create a splash screen or landing screen. */
            splashScreenDelegate scd = (time) =>
            {
                Console.WriteLine("Loading . . . ");

                /* Changing the background and foreground colors of the console. */
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                /* This is a for loop that is used to create a countdown. */
                for (int i = time; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }

                /* This is a welcome message that is being displayed to the user. */
                Console.WriteLine("\n\n\t==================================================");
                Console.WriteLine("\t||\tWelcome to your Budget Planner    \t||");
                Console.WriteLine("\t==================================================\n\n");


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            };



            /* This is a series of methods that are being called. */
            scd.Invoke(1);
            acc.getIncome();
            acc.GetInput();

            /* Calling the reduceBalance method and passing the calcTotalExpenses method as a parameter. */
            acc.reduceBalance(acc.calcTotalExpenses());
            acc.GetHousing();

            /* Calling the checkApprovalLikeliness method and passing the GrossMonthlyIncome method as a
            parameter. */
            acc.checkApprovalLikeliness(acc.GrossMonthlyIncome);
            acc.showBalance();


            Console.ReadLine();
        }
    }
}
