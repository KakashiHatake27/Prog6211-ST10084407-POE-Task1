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
            Console.WriteLine("\n EXPENSES:\n-------------------");

            Console.Write("Enter estimated monthly tax: ");
            addExpense(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine("\nPlease enter monthly estimated cost of the following:");

            Console.Write("Groceries: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Water and lights: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Travel costs(including fuel): R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Cell phone and Telephone: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Any other miscellanous expenses: R ");
            addExpense(Convert.ToDouble(Console.ReadLine()));
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


            return totalExpenses;
        }

       
    }




}

