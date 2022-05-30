using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class VehiclePurchaseClass
    {
        private double PurchasePrice;
        private double TotalDeposit;
        private double InterestRate;
        private double InsurancePremium;
        private string ModelandMake;
        private int numMonths;
        
        public double GetPurchasePrice
        {
            get { return PurchasePrice; }
            set { PurchasePrice = value; }
        }

        public double GetTotalDeposit
        {
            get { return TotalDeposit; }
            set { TotalDeposit = value; }
        }

        public double GetInterestRate
        {
            get { return InterestRate; }
            set { InterestRate = value; }
        }

        public double GetInsurancePremium
        {
            get { return InsurancePremium; }
            set { InsurancePremium = value; }
        }

        public string GetModelandMake
        {
            get { return ModelandMake; }
            set { ModelandMake = value; }
        }

        public int GetnumMonths
        {
            get { return numMonths; }
            set { numMonths = value; }
        }

        public VehiclePurchaseClass()
        {
            GetPurchasePrice = 0;
            GetTotalDeposit = 0;
            GetInterestRate = 0;
            GetInsurancePremium = 0;
            GetModelandMake = " ";
            GetnumMonths = 0;
        }

        public VehiclePurchaseClass(double PP, double TD, double IR, double IP,  string MM, int nM)
        {
            PurchasePrice = PP;
            TotalDeposit = TD;
            InterestRate = IR;
            InsurancePremium = IP;
            ModelandMake = MM;
            numMonths = nM;
        }

        public double HirePurchase()
        {
            double P = PurchasePrice - TotalDeposit;
            double A = P * (1 + (InterestRate * numMonths));
            return A;
        }

        public double MonthlyVehiclePurchaseRepayment()
        {
            double MonthlyPayments = HirePurchase() / numMonths;
            return MonthlyPayments;
        }

        public double CalculateTotalMonthlyCost()
        {
            double total;
            total = MonthlyVehiclePurchaseRepayment() + InsurancePremium;
            return total;
        }

        public virtual string ToDisplay()
        {
            string message = "Total monthly Payments for the car is" + CalculateTotalMonthlyCost().ToString("C");
            return message;
        }
    }
}
