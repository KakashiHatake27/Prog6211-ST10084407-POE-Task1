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


        /// It gets the user's input and stores it in an array

        public void GetInput()
        {
            /* Creating an array of 10 elements. */
            arrExpenses = new double[10];


            /* Printing the heading for expeneses. */
            Console.WriteLine("\n EXPENSES:\n-------------------");

            /* Asking the user to enter the estimated monthly tax and then it is converting it to a
            double and then it is adding it to the array. */
            Console.Write("Enter estimated monthly tax: ");
            addExpense(Convert.ToDouble(Console.ReadLine()));


            /* Printing the text "Please enter monthly estimated cost of the following:" on the console. */
            Console.WriteLine("\nPlease enter monthly estimated cost of the following:");

            /* Asking the user to enter the estimated monthly expenses of the items and then it is converting it to a
                        double and then it is adding it to the array. */
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


        /// It adds an expense to the array.

        public void addExpense(double exp)
        {

            arrExpenses[counter] = exp;
            counter++;
        }


        /// This function calculates the total expenses of the company by adding all the expenses in the
        /// array
        /// returns
        /// The total expenses.
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

