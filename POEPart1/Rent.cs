using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class Rent
    {

        public double rental;

        public Rent()
        {
        }

        public double GetRental()
        {
            Console.Write("\nPlease enter monthly rental amount: ");
            rental = Convert.ToDouble(Console.ReadLine());
            return rental;

        }
    }
}
