using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class ExpensesClass
    {
        private double total;
        private double Gross_monthly_income;
        private double monthly_tax_deducted;
        private double Groceries;
        private double Water_and_Lights;
        private double Travel_costs;
        private double Cellphone_and_telephone;
        private double OtherExpenses;
        private string AccodationType;
        private double RentAmount;

        public double GetGrossMonthlyIncome
        { 
            get { return Gross_monthly_income; }
            set { Gross_monthly_income = value; } 
        }

        public double GetMonthlyTaxDeducted
        {
            get { return monthly_tax_deducted; }
            set { monthly_tax_deducted = value; }
        }

        public double GetGroceries
        {
            get { return Groceries; }
            set { Groceries = value; }
        }

        public double GetWater_and_Lights
        {
            get { return Water_and_Lights; }
            set { Water_and_Lights = value; }
        }

        public double GetTravel_costs
        {
            get { return Travel_costs; }
            set { Travel_costs = value; }
        }

        public double GetCellphone_and_telephone
        {
            get { return Cellphone_and_telephone; }
            set { Cellphone_and_telephone = value; }
        }

        public double GetOtherExpenses
        {
            get { return OtherExpenses; }
            set { OtherExpenses = value; }
        }

        public string GetAccodationType
        {
            get { return AccodationType; }
            set { AccodationType = value; }
        }

        public double GetRentAmount
        { 
            get { return RentAmount; } 
            set { RentAmount = value; } 
        }

        public ExpensesClass()
        {
            GetGrossMonthlyIncome = 0;
            GetMonthlyTaxDeducted = 0;
            GetGroceries=0;
            GetWater_and_Lights=0;
            GetTravel_costs=0;
            GetCellphone_and_telephone = 0;
            GetOtherExpenses=0;
            GetAccodationType = " ";
            GetRentAmount = 0;
        }

        public ExpensesClass(double GMT,double MTD, double G, double WL, double TC, double CAT, double OE, string A, double RA)
        {
            Gross_monthly_income=GMT;
            monthly_tax_deducted = MTD;
            Groceries=G;
            Water_and_Lights=WL;
            Travel_costs=TC;
            OtherExpenses=OE;
            AccodationType = A;
            RentAmount = RA;
        }

        public virtual  double MoneyAvailable()
        {
            double subtotal = 0;
            total=0;
            if (GetAccodationType== "Renting Accommodation")
            {
                subtotal= GetMonthlyTaxDeducted+GetGroceries+GetWater_and_Lights+GetTravel_costs+GetOtherExpenses+GetRentAmount;
                total=GetGrossMonthlyIncome-subtotal;
            }

            return total;
        }

        public virtual string ToDisplay()
        {
            string message= "Your available money after deduction will be "+ MoneyAvailable().ToString("C");
            return message;
        }

    }
}
