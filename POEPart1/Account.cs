using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1
{
    /* A delegate that is being used to get the monthly rental amount from the user. */
    public delegate double getRentalDelegate();

    /* Inheriting the Expenses class. */
    internal class Account : Expenses
    {

        /* Declaring the variables. */
        private double grossMonthlyIncome;
        private double accountBalance;



        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }


        private int housing;

        /* Creating a new instance of the HomeLoan class. */
        HomeLoan hl = new HomeLoan();


        /* Creating a delegate. */
        public delegate void homeLoanDelegate();
        public delegate double getRentalDelegate();


        /// It displays the account balance in the console
        public void showBalance()
        {
            Console.WriteLine("\n\n=======================================");
            Console.Write("Available balance: ");

            /* Checking if the account balance is less than 0, if it is, it will display the account
            balance in red. If it is not, it will display the account balance in green. */
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


        /// The function getIncome() gets the gross monthly income from the user and increases the
        /// balance by the gross monthly income.
        /// returns
        /// The grossMonthlyIncome is being returned.
        public double getIncome()
        {

            Console.WriteLine("\n INCOME AND TAX:\n-------------------");

            Console.Write("Enter Gross monthly income(before taxes): R ");
            grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

            increaseBalance(grossMonthlyIncome);

            return grossMonthlyIncome;
        }


        /// The function is supposed to ask the user to select between renting or buying a property. If
        /// the user selects renting, the function should call the delegate grd which will ask the user
        /// to enter the monthly rental amount. If the user selects buying a property, the function
        /// should call the getHomeLoan() function which is in the HomeLoan class
        public void GetHousing()
        {
            /* A delegate that is being used to get the monthly rental amount from the user. */
            getRentalDelegate grd = () =>
            {
                double rental;
                Console.Write("\nPlease enter monthly rental amount: R ");
                rental = Int32.Parse(Console.ReadLine());
                return rental;
            };

            Console.WriteLine("\n ACCOMMODATION:\n-------------------");

            /* Asking the user to select between renting or buying a property. */
            Console.WriteLine("\nPlease enter number to select your accommodation\n\t[1] Renting\n\t[2] Buying a property");
            Console.Write(" --> ");
            housing = Int32.Parse(Console.ReadLine());

            /* Asking the user to select between renting or buying a property. Depending on the selection the 
            appropriate action is executed*/
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
                /* If it is an invalid input it shows the following error and runs the method again. */

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Invalid input, Please try again.\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                GetHousing();
            }

        }



        /// This function reduces the balance of the account by the amount passed in as a parameter
        ///The amount to reduce the balance by.
        public void reduceBalance(double reduction)
        {
            accountBalance -= reduction;
        }


        /// It increases the balance of the account by the amount passed in.
        /// The amount to increase the balance by
        public void increaseBalance(double increase)
        {
            accountBalance += increase;
        }


        /// This function checks if the monthly loan repayment is less than a third of the gross monthly
        /// income. If it is, it prints an alert to the console
        /// gmi = Gross Monthly Income
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
