using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class HomeLoan
    {
        double purchasePrice;
        double totalDeposit;
        double interest;
        int monthsRepay;

        public void getHomeLoan()
        {
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Please enter the following details for a home loan: ");

            Console.Write("\nPurchase price of property: ");
            purchasePrice = Int32.Parse(Console.ReadLine());

            Console.Write("Total Deposit: ");
            totalDeposit = Int32.Parse(Console.ReadLine());

            Console.Write("Interest rate (in percentage %): ");
            interest = Int32.Parse(Console.ReadLine());

            Console.Write("Number of months to repay (240 - 360): ");
            monthsRepay = Int32.Parse(Console.ReadLine());
        }




    }
}
