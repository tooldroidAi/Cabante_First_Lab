using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabante_Final_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalSales_Danielle = 0;
        private double totalSales_Edward = 0;
        private double totalSales_Fatima = 0;


        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                totalSales_Danielle += salesAmount;
                label_Output.Text = $"{salesAmount} in sales has been successfully recorded for \nDanielle. bringing  his/her total sales to {totalSales_Danielle}"; 
            }
            else if (salesInitial == "E")
            {
                totalSales_Edward += salesAmount;
                label_Output.Text = $"{salesAmount}in sales has been successfully recorded for \nEdward. bringing  his/her total sales to {totalSales_Edward}";

            }
            else if (salesInitial == "F")
            {
                totalSales_Fatima += salesAmount;
                label_Output.Text = $"{salesAmount}in sales has been successfully recorded for \nFatima. bringing  his/her total sales to {totalSales_Fatima}";
            }
            else
            {
                label_Output.Text = "Invalid Sales Person Initial.";
            }
            }
          
        private void clearEntry()
        {
            textBox_Initial.Text = "";
            textBox_AmountOfSale.Text = "";
            label_Output.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click_Click(object sender, EventArgs e)
        {
            double saleAmount;
            if (double.TryParse(textBox_AmountOfSale.Text, out saleAmount))
            {
                getSalesPerson_Amount(textBox_Initial.Text, saleAmount);
            }
            else
            {
                label_Output.Text = "Please enter a valid number for the sale amount.";
            }
        }


        private void Btn_Clear_Click_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(
                totalSales_Danielle, totalSales_Edward, totalSales_Fatima);
            form2.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}