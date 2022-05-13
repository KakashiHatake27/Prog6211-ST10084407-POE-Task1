using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class HomeLoan
    {
        private double purchasePrice;
        private double totalDeposit;
        private double interest;
        private int monthsRepay;
        private double principleAmount;
        private double totalOutstanding;
       private  double homeLoanRepayments;


        public void getHomeLoan()
        {
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Please enter the following details for a home loan: ");

            Console.Write("\nPurchase price of property: ");
            purchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Total Deposit: ");
            totalDeposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Interest rate (in percentage %): ");
            interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nnumber of months to complete payment: ");
            monthsRepay = Int32.Parse(Console.ReadLine());

            calcMonthlyLoanRepayment();
        }

        public double calcMonthlyLoanRepayment() {

            principleAmount = purchasePrice - totalDeposit;
            interest = interest / 100;
            int years = monthsRepay / 12;
            
            totalOutstanding = principleAmount * (1 + (interest * years));

            homeLoanRepayments = totalOutstanding / monthsRepay;
            homeLoanRepayments = Math.Round(homeLoanRepayments, 2);

            return homeLoanRepayments;
        }




    }
}
