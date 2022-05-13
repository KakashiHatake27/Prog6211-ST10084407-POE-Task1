using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    abstract class Expenses
    {
        private double[] arrExpenses;

        private int counter = 0;

        public void GetInput()
        {
            arrExpenses = new double[10];

             Console.Write("Enter monthly tax deducted: ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for groceries: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for Water and Lights: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for travel costs(including petrol): R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter monthly expense for Cell phone and Telephone: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Enter any other miscellanous expenses: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            calcTotalExpenses();

        }

        public void addExpense(double exp)
        {

            arrExpenses[counter] = exp;
            counter++;
        }

        public double calcTotalExpenses()
        {
            double totalExpenses = 0;
            for (int i = 0; i < arrExpenses.Length; i++)
            {
                totalExpenses = totalExpenses + arrExpenses[i];
            }

            //reduceBalance(totalExpenses);

            return totalExpenses;
        }

       


    }




}

