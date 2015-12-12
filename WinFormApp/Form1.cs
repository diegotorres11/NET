using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey($@"SOFTWARE\Apps\{this.Name}");

            if (registry == null) return;

            Left = (int)registry.GetValue("Left");
            Top = (int)registry.GetValue("Top");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey registry = Registry.CurrentUser.CreateSubKey($@"SOFTWARE\Apps\{this.Name}");

            registry.SetValue("Left", this.Left);
            registry.SetValue("Top", this.Top);
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
