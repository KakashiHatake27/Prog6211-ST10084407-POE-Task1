using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1
{

    internal class Account : Expenses
    {


        public HomeLoan hl = new HomeLoan();
        public delegate void homeLoanDelegate();
        public delegate double getRentalDelegate();

        public void SplashScreen() {
            Console.WriteLine("Loading . . . ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }


            Console.WriteLine("\n\n\t\tWelcome to the Budget Planner App");
            Console.WriteLine("\t===========================================\n\n");
            //Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GetInput()
        {


            Console.Write("Enter Gross monthly income (before taxes): R ");
            GrossMonthlyIncome = Int32.Parse(Console.ReadLine());


            Console.Write("Enter monthly tax deducted: ");
            MonthlyTax = Int32.Parse(Console.ReadLine());

            Console.Write("Enter monthly expense for groceries: R ");
            ExpGroceries = Int32.Parse(Console.ReadLine());

            Console.Write("Enter monthly expense for Water and Lights: R ");
            ExpWaterLights = Int32.Parse(Console.ReadLine());


            Console.Write("Enter monthly expense for travel costs(including petrol): R ");
            ExpTravel = Int32.Parse(Console.ReadLine());

            Console.Write("Enter monthly expense for Cell phone and Telephone: R ");
            ExpPhone = Int32.Parse(Console.ReadLine());

            Console.Write("Enter any other miscellanous expenses: R ");
            ExpOther = Int32.Parse(Console.ReadLine());


            GetHousing();

        }

        public void GetHousing()
        {
            Console.WriteLine("Please enter number to select your accommodation\n\t[1] Renting\n\t[2] Buying a property");
            Console.Write("-->");
            Housing = Int32.Parse(Console.ReadLine());

            
            if (Housing == 1)
            {
                GetRental();

                getRentalDelegate grd = () =>
                {
                    Console.Write("\nPlease enter monthly rental amount: ");
                    Rental = Int32.Parse(Console.ReadLine());
                    return Rental;
                };
            }
            else if (Housing == 2)
            {
                hl.getHomeLoan();
            }
            else
            {
                Console.WriteLine("Invalid input");

                GetHousing();
            }

        }



        public void GetRental()
        {
            Console.Write("\nPlease enter monthly rental amount: ");
            Rental = Int32.Parse(Console.ReadLine());
        }

      
    }
}
