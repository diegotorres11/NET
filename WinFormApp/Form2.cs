using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblTitle_Load(object sender, EventArgs e)
        {

        }

        public void lblTitleText(string text)
        {
            lblTitle.Text = text;
        }
    }
}
