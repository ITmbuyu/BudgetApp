using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class HomeLoanClass:ExpensesClass
    {
        private double Purchaseprice;
        private double Totaldeposit;
        private double Interestrate;
        private int monthstorepay;
        private string Hmessage;

        public double GetPurchaseprice
        {
            get { return Purchaseprice; }
            set { Purchaseprice = value; }
        }

        public double GetTotaldeposit
        {
            get { return Totaldeposit; }
            set { Totaldeposit = value; }
        }

        public double GetInterestrate
        {
            get { return Interestrate; }
            set { Interestrate = value; }
        }

        public int GetMonthstorepay
        {
            get { return monthstorepay; }
            set { monthstorepay = value; }
        }

        public HomeLoanClass():base()
        {
            GetPurchaseprice = 0;
            GetTotaldeposit = 0;
            GetInterestrate = 0;
            GetMonthstorepay = 0;
            Hmessage = "";
        }

        public HomeLoanClass(double PP,double TP, double IR, int MTR, double GMT, double MTD, double G, double WL, double TC, double CAT, double OE, string A, double RA) : base(GMT,MTD, G,WL,TC,CAT,OE,A,RA)
        {
            Purchaseprice = PP;
            Totaldeposit = TP;
            Interestrate = IR;
            monthstorepay = MTR;
        }

        public double HirePurchase()
        {
            double P = Purchaseprice - Totaldeposit;
            double A= P*(1+(Interestrate*monthstorepay));
            return A;
        }

        public double MonthlyHomeLoanRepayment()
        {
            double MonthlyPayments = HirePurchase()/monthstorepay;
            if (MonthlyPayments > (GetGrossMonthlyIncome/3))
            {
                MonthlyPayments = 0;
                Hmessage = "approval of the home loan is unlikely.";
            }
            return MonthlyPayments;
        }

        public override double MoneyAvailable()
        {
            double subtotal = 0;
            double total = 0;
            if (GetAccodationType == "Buying A Property")
            {
                subtotal = GetMonthlyTaxDeducted + GetGroceries + GetWater_and_Lights + GetTravel_costs + GetOtherExpenses + MonthlyHomeLoanRepayment();
                total = GetGrossMonthlyIncome - subtotal;
            }

            return total;
        }

        public override string ToDisplay()
        {
            string message = "Monthly Payment Fee for the house is " + MonthlyHomeLoanRepayment().ToString("C")+ "\nYour available money after deduction will be " + MoneyAvailable().ToString("C");
            if (MonthlyHomeLoanRepayment()==0)
            {
                message= Hmessage+"\nYour available money after deduction will be " + MoneyAvailable().ToString("C");
            }
            return message;
        }


    }
}
