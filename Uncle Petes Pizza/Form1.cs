using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Uncle_Petes_Pizza
{
    public partial class Form1 : Form
    {
        int pizza = 10;
        int wings = 5;
        int bread = 5;
        int amountpizza;
        int amountwings;
        int amountbread;
        int amountchange;
        int payment;
        double totalcost;
        double finalcost;
        double tax = 0.13;
        double finaltax;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcTotalButton_Click(object sender, EventArgs e)
        { 

            amountpizza = Convert.ToInt32(PizzaBox.Text);
            amountwings = Convert.ToInt32(WingBox.Text);
            amountbread = Convert.ToInt32(BreadBox.Text);

            totalcost = amountpizza * pizza + amountwings * wings + amountbread * bread;
            SubTotBox.Text = $"{totalcost}";
            finaltax = tax * totalcost;
            TaxBox.Text = $"{finaltax}";
            finalcost = finaltax + totalcost;
            TotalBox.Text = $"{finalcost}";  
        }

        private void CalcChangeButton_Click(object sender, EventArgs e)
        {
            ChangeTitle.Text = $"Total Price is {totalcost.ToString("C")}";
            payment = Convert.ToInt32(PayBox.Text);
            change = payment - finalcost;
            ChangeTitle.Text = $"Your Change is {change.ToString("C")}";

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
           Receipt.Visible = true;
            ReceiptPizza.Text = $"{amountpizza}";
            ReceiptWings.Text = $"{amountwings}";
            ReceiptGarlic.Text = $"{amountbread}";

            ReceiptSub.Text = $"{totalcost}";
            ReceiptTax.Text = $"{finaltax}";
            ReceiptTotal.Text = $"{finalcost}";
            ReceiptChange.Text = $"{change}";
        }

        
    }
}
