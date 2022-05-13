using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1
{
    public delegate double getRentalDelegate();

    internal class Account : Expenses
    {

        private double grossMonthlyIncome;
        private double accountBalance;

        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }

        private int housing;

        HomeLoan hl = new HomeLoan();


        public delegate void homeLoanDelegate();
        public delegate double getRentalDelegate();

        public void showBalance()
        {
            Console.WriteLine("\n\n=======================================");
            Console.Write("Available balance: ");
            if (accountBalance < 0)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(accountBalance);
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(accountBalance);

            }

            }

        public double getIncome()
        {

            Console.WriteLine("\n INCOME AND TAX:\n-------------------");

            Console.Write("Enter Gross monthly income(before taxes): R ");
            grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

            increaseBalance(grossMonthlyIncome);

            return grossMonthlyIncome;
        }

        public void GetHousing()
        {
            getRentalDelegate grd = () =>
            {
                double rental;
                Console.Write("\nPlease enter monthly rental amount: R ");
                rental = Int32.Parse(Console.ReadLine());
                return rental;
            };

            Console.WriteLine("\n ACCOMMODATION:\n-------------------");

            Console.WriteLine("\nPlease enter number to select your accommodation\n\t[1] Renting\n\t[2] Buying a property");
            Console.Write(" --> ");
            housing = Int32.Parse(Console.ReadLine());

            if (housing == 1)
            {
                grd.Invoke();
            }
            else if (housing == 2)
            {
                hl.getHomeLoan();
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine("Invalid input, Please try again.\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                GetHousing();
            }

        }


        public void reduceBalance(double reduction)
        {
            accountBalance -= reduction;
        }

        public void increaseBalance(double increase)
        {
            accountBalance += increase;
        }

        public void checkApprovalLikeliness(double gmi)
        {
            if ((gmi / 3) < hl.calcMonthlyLoanRepayment())
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("\nALERT: The approval of this home loan is unlikely");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
