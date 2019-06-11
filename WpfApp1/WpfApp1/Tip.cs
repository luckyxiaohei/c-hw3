using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Tip
    {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }

        public  Tip()
        {
            this.BillAmount = String.Empty;
            this.TipAmount = String.Empty;
            this.TotalAmount = String.Empty;
        }

        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if (double.TryParse(originalAmount.Replace('$', ' '), out billAmount))
            {
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }
            CultureInfo c = new CultureInfo("en-US");


            this.BillAmount = billAmount.ToString("C", c);
            this.TipAmount =  tipAmount.ToString("C", c);
            this.TotalAmount =totalAmount.ToString("C", c);

        }
    }
}
