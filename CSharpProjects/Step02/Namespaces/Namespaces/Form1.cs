﻿using System;
using System.Windows.Forms;
using System.IO;


namespace Namespaces {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int x;
            string currdir;     
            x = 10;
            textBox1.Text = System.String.Format("Value of x = {0}\n", x);
            currdir = Directory.GetCurrentDirectory();
            textBox1.AppendText("This is the current directory: " + currdir);
        }
    }
}
