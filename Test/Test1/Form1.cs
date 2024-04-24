using System;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d = Double.Parse("15.8");
            int i = Int16.Parse("15");
            textBox1.Text = String.Format("{0} - {1}", d.ToString("F1"), i);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
