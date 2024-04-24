﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Methods {
    public partial class Form1 : Form {
        public Form1( ) {
            InitializeComponent( );
        }

        private void showMessage( string aString, int aNumber ) {
            textBox1.AppendText(aString + aNumber + "\n\r" );
        }

        private void showMessage( string aMessage ) {
            textBox1.AppendText( aMessage + "\n\r");
        }

        private string addNumbers( int num1, int num2 ) {
            return "The total of " + num1 + " plus " + num2 + " is " + (num1+num2) + "\n\r";
        }

        private int add(int num1, int num2) {
            return num1 + num2;
        }

        private void greet( string aName ) {
            textBox1.AppendText( "Hello, " + aName + "\n\r");
        }

        private void sayHello( ) {
            textBox1.AppendText("Hello\n\n");
        }

        private void testBtn_Click( object sender, EventArgs e ) {
            string calcResult;
            string someName;
            int total;
            textBox1.Clear( );
            sayHello( );
            greet( "Mary" );
            someName = "Fred";
            greet( someName );
            calcResult = addNumbers( 100, 200 );
            total = add(60, 12);
            textBox1.AppendText("total = " + total + "\n\r");
            textBox1.AppendText( "25 + 15 = " + add(25, 15) + "\n\r");
            textBox1.AppendText( calcResult );
            textBox1.AppendText( addNumbers( 550, 750 ) );
            showMessage( addNumbers( 3000, 7000 ) );
            showMessage("You have $", 500 );
        }

        private void outParams( out int num1, out int num2 ) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText( "In outParams, num1 = " + num1 + ", num2 = " + num2 + "\n\r");
        }

        private void byReference( ref int num1, ref int num2 ) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText( "In byReference, num1 = " + num1 + ", num2 = " + num2 + "\n\r");
        }

        private void byValue( int num1, int num2 ) {
            num1 = 0;
            num2 = 1;
            textBox1.AppendText( "In byValue, num1 = " + num1 + ", num2 = " + num2 + "\n\r");
        }

        private void paramTestBtn_Click( object sender, EventArgs e ) {
            int firstnumber;
            int secondnumber;
            textBox1.Clear( );

            firstnumber = 10;
            secondnumber = 20;
            byValue( firstnumber, secondnumber );
            textBox1.AppendText( "Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\n\r");
            
            firstnumber = 10;
            secondnumber = 20; 
            byReference( ref firstnumber, ref secondnumber );
            textBox1.AppendText( "Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\n\r");

            firstnumber = 10;
            secondnumber = 20; 
            outParams( out firstnumber, out secondnumber );
            textBox1.AppendText( "Now firstnumber = " + firstnumber + ", secondnumber = " + secondnumber + "\n\r");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
