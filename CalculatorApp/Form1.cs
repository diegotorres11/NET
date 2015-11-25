using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtCalculation.KeyUp += (sender, e) =>
            {
                 
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Click += (emisor, evento) =>
                    {
                        txtCalculation.Text += ((Button)emisor).Text;
                    };
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var numeros = txtCalculation.Text.Split('+', '-', '*', '/');
        }
    }
}
