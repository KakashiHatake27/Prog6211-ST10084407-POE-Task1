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
            Account acc = new Account();


            splashScreenDelegate scd = (time) => {
                Console.WriteLine("Loading . . . ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                for (int i = time; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }


                Console.WriteLine("\n\n\t==================================================");
                Console.WriteLine("\t||\tWelcome to your Budget Planner    \t||");
                Console.WriteLine("\t==================================================\n\n");
               

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            };

            accountDelegate accd = () => {
               
            };

            scd.Invoke(1);
            acc.getIncome();
            acc.GetInput();
            acc.reduceBalance(acc.calcTotalExpenses());
            acc.GetHousing();
            acc.checkApprovalLikeliness(acc.GrossMonthlyIncome);
            acc.showBalance();


            Console.ReadLine();
        }
    }
}
