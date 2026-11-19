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
    public partial class Form2 : Form
    {
        public Form2(double Danielle,
                        double Edward,
                        double Fatima
           )
        {
            InitializeComponent();

            // labelPrint.Text = $"Danielle: {Danielle:C}\nEdward: {Edward:C}\nFatima: {Fatima:C}\n\nTotal: {(Danielle + Edward + Fatima):C}";
            labelAmountDanielle.Text = Danielle.ToString("C");
            labelAmountEdward.Text = Edward.ToString("C");
            labelAmountFatima.Text = Fatima.ToString("C");
            labelTotal.Text = (Danielle + Edward + Fatima).ToString("C");
    

        }
    }
}
