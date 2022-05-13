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

        private double accountBalance;

        public int housing;
        //public double rental;

        public HomeLoan hl = new HomeLoan();
        public delegate void homeLoanDelegate();
        public delegate double getRentalDelegate();


        public void GetHousing()
        {
            GetInput();

            Rent r = new Rent();
            //getRentalDelegate gr = new getRentalDelegate();

            Console.WriteLine("Please enter number to select your accommodation\n\t[1] Renting\n\t[2] Buying a property");
            Console.Write("-->");
            housing = Int32.Parse(Console.ReadLine());

            if (housing == 1)
            {
                //r.GetRental();

                getRentalDelegate grd = () =>
                {
                    double rental;
                    Console.Write("\nPlease enter monthly rental amount: ");
                    rental = Int32.Parse(Console.ReadLine());
                    return rental;
                };
            }
            else if (housing == 2)
            {
                hl.getHomeLoan();
            }
            else
            {
                Console.WriteLine("Invalid input");

                GetHousing();
            }

        }

        //public void GetRental()
        //{
        //    Console.Write("\nPlease enter monthly rental amount: ");
        //    rental = Convert.ToDouble(Console.ReadLine());
        //}

        public void reduceBalance(double reduction)
        {
            accountBalance -= reduction;
        }

        public void increaseBalance(double increase)
        {

            accountBalance += increase;
        }

        public void checkApprovalLikeliness(double gmi) {
            if ((gmi / 3) < hl.calcMonthlyLoanRepayment())
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}
