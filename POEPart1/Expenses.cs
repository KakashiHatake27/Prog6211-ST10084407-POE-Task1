using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{

    abstract class Expenses
    {
        private double grossMonthlyIncome;
        private double monthlyTax;
        private double expGroceries;
        private double expWaterLights;
        private double expTravel;
        private double expPhone;
        private double expOther;
        private int housing;
        private double rental;

        private double[][] arrexpenses; 


        public double GrossMonthlyIncome { get => grossMonthlyIncome; set => grossMonthlyIncome = value; }
        public double MonthlyTax { get => monthlyTax; set => monthlyTax = value; }
        public double ExpGroceries { get => expGroceries; set => expGroceries = value; }
        public double ExpWaterLights { get => expWaterLights; set => expWaterLights = value; }
        public double ExpTravel { get => expTravel; set => expTravel = value; }
        public double ExpPhone { get => expPhone; set => expPhone = value; }
        public double ExpOther { get => expOther; set => expOther = value; }
        public int Housing { get => housing; set => housing = value; }
        public double Rental { get => rental; set => rental = value; }
        public double[][] Arrexpenses { get => arrexpenses; set => arrexpenses = value; }
    }
}

