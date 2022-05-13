using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{

    abstract class Expenses
    {
        //private double grossMonthlyIncome;
        //private double monthlyTax;
        //private double expGroceries;
        //private double expWaterLights;
        //private double expTravel;
        //private double expPhone;
        //private double expOther;

        private double[] arrExpenses;
        //private List<double> expenses;
        //expenses = new List<dynamic>();


        private int counter = 0;

        public void GetInput()
        {
            arrExpenses = new double[10];

            Console.Write("Enter Gross monthly income (before taxes): R ");
            //grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));
            //arrExpenses[0] = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(arrExpenses[0]);

            Console.Write("Enter monthly tax deducted: ");
            //monthlyTax = Convert.ToDouble(Console.ReadLine());
           addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for groceries: R ");
            //expGroceries = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for Water and Lights: R ");
            //expWaterLights = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for travel costs(including petrol): R ");
            //expTravel = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for Cell phone and Telephone: R ");
            //expPhone = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter any other miscellanous expenses: R ");
            //expOther = Convert.ToDouble(Console.ReadLine());
            addExpense(Convert.ToDouble(Console.ReadLine()));

            calcTotalExpenses();

        }

        public void addExpense(double exp) {

            arrExpenses[counter] =exp;
            counter++;
        }

        public double calcTotalExpenses() {
            double totalExpenses = 0;
            for (int i = 0; i < arrExpenses.Length; i++)
            {
                totalExpenses = totalExpenses + arrExpenses[i];
            }

            Account acc = new Account();
            acc.reduceBalance(totalExpenses);

            return totalExpenses;
        }

        //public double calcTotalExpenses()
        //{
        //    double totalExpenses = 0;

        //    for (int i = 0; i < arrExpenses.Length; i++)
        //    {
        //        totalExpenses+=i;
        //        Console.WriteLine(totalExpenses);
            

        //    }

        //    //Account acc = new Account();
        //    //acc.reduceBalance(totalExpenses);


        //    return totalExpenses;

        //}

    }




}

