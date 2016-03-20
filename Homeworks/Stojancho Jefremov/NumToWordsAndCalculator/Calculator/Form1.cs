using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            var display = txtDisplay;
            var result = Calculator.ProcessInput((sender as Button).Text.First(), display.Text);
			display.Text = result;
            //btnEquals to be in focus, so if user press Enter this button will be activated
            btnEquals.Select();
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keyPressed = e.KeyChar;

            var allowedKeys = new Collection<char>
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-',
                '=', '+', '/', '*', '\u001b'};//ESC = '\u001b'

            if (!allowedKeys.Contains(e.KeyChar))
            {
                return;
            }

            if (keyPressed == '\u001b')
            {
                keyPressed = 'C';
            }
            
            var display = txtDisplay;
            var result = Calculator.ProcessInput(keyPressed, display.Text);
            display.Text = result;
            //btnEquals to be in focus, so if user press Enter this button will be activated
            btnEquals.Select();
           
        }
    }
}
