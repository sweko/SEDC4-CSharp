using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleWindowsFormCalculator
{
    public partial class CalculatorMainWindow : Form
    {
        // Globals
        bool clearTB = false;
        bool functionPressed = false;

        int functionSwitch = 0;
        double oldNum = 0; //First number entered
        double newNum = 0; //Second number entered
        double answer;

        public CalculatorMainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyPress) //Handles keyboard input
        {
            //Function buttons and period button
            if (keyPress == Keys.Add)
            {
                btnAdd.PerformClick();
            }
            if (keyPress == Keys.Subtract)
            {
                btnMinus.PerformClick();
            }
            if (keyPress == Keys.Multiply)
            {
                btnMulti.PerformClick();
            }
            if (keyPress == Keys.Divide)
            {
                btnDivide.PerformClick();
            }
            if (keyPress == Keys.Enter)
            {
                btnEqual.PerformClick();
            }
            if (keyPress == Keys.OemPeriod || keyPress == Keys.Decimal)
            {
                btnPeriod.PerformClick();
            }
            if (keyPress == Keys.Back)
            {
                btnBackspace.PerformClick();
            }
            if (keyPress == Keys.Delete)
            {
                btnBackspace.PerformClick();
            }

            //Number buttons
            if (keyPress == Keys.NumPad0 || keyPress == Keys.D0)
            {
                btnNum0.PerformClick();
            }
            if (keyPress == Keys.NumPad1 || keyPress == Keys.D1)
            {
                btnNum1.PerformClick();
            }
            if (keyPress == Keys.NumPad2 || keyPress == Keys.D2)
            {
                btnNum2.PerformClick();
            }
            if (keyPress == Keys.NumPad3 || keyPress == Keys.D3)
            {
                btnNum3.PerformClick();
            }
            if (keyPress == Keys.NumPad4 || keyPress == Keys.D4)
            {
                btnNum4.PerformClick();
            }
            if (keyPress == Keys.NumPad5 || keyPress == Keys.D5)
            {
                btnNum5.PerformClick();
            }
            if (keyPress == Keys.NumPad6 || keyPress == Keys.D6)
            {
                btnNum6.PerformClick();
            }
            if (keyPress == Keys.NumPad7 || keyPress == Keys.D7)
            {
                btnNum7.PerformClick();
            }
            if (keyPress == Keys.NumPad8 || keyPress == Keys.D8)
            {
                btnNum8.PerformClick();
            }
            if (keyPress == Keys.NumPad9 || keyPress == Keys.D9)
            {
                btnNum9.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyPress);
        }

        // Operator Button Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            functionSwitch = 1;
            OperatorFunction(" + ");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            functionSwitch = 2;
            OperatorFunction(" - ");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            functionSwitch = 3;
            OperatorFunction(" * ");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            functionSwitch = 4;
            OperatorFunction(" / ");
        }
        

        //Math operations
        private void btnEqual_Click(object sender, EventArgs e)
        {
            

            if (functionPressed)
            {
                displayLabel.Text += textBox.Text;
                if (functionPressed && textBox.Text != "")
                {
                    newNum = Convert.ToDouble(textBox.Text);
                }
                else if (textBox.Text != "")
                {
                    oldNum = Convert.ToDouble(textBox.Text);
                }

                if (newNum != 0 && oldNum != 0)
                {
                    DoMath();

                    displayLabel.Text += " = " + answer.ToString();
                    newNum = 0;
                }

                functionPressed = false;
            }
        }

        private void DoMath()
        {
            if (textBox.Text != null)
            {
                switch (functionSwitch)
                {
                    case 1: //Add
                        answer = oldNum + newNum;
                        break;

                    case 2: //Sub
                        answer = oldNum - newNum;
                        break;

                    case 3: //Multi
                        answer = oldNum * newNum;
                        break;

                    case 4: //Divide
                        answer = oldNum / newNum;
                        break;

                    default:
                        break;
                }
                textBox.Text = answer.ToString();
                clearTB = true;
            }
        }

        private void OperatorFunction(string operatorKey)
        {
            if (functionPressed && textBox.Text != "")
            {
                newNum = Convert.ToDouble(textBox.Text);
                displayLabel.Text += newNum + operatorKey;
            }
            else if (textBox.Text != "")
            {
                oldNum = Convert.ToDouble(textBox.Text);
                displayLabel.Text = oldNum + operatorKey;
            }

            if (newNum == 0)
            {
                textBox.Clear();
            }
            else
            {
                DoMath();
                oldNum = answer;
            }

            functionPressed = true;
        }

        private void Numbers(int numSelection)
        {
            if (clearTB)
            {
                textBox.Text = numSelection.ToString();
                clearTB = false;
            }
            else
            {
                textBox.Text += numSelection.ToString();
            }
        }
        

        // Number Button Events
        private void btnNum1_Click(object sender, EventArgs e)
        {
            Numbers(1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            Numbers(2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            Numbers(3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            Numbers(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            Numbers(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            Numbers(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            Numbers(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            Numbers(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            Numbers(9);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            Numbers(0);
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(".")) //Makes sure user can't type number with multiple "."
            textBox.Text = textBox.Text.ToString() + ".";
        }
       

      
        private void btnClear_Click(object sender, EventArgs e) //Returns everything to default for new entry and returns focus
        {
            textBox.Clear();
            displayLabel.Text = "";

            functionPressed = false;
            clearTB = false;
            functionSwitch = 0;
            newNum = 0;
            oldNum = 0;
            answer = 0;

            this.Width = 200;
        }

        private void btnEsc_Click(object sender, EventArgs e)  //Opens msgbox when pressing "Esc"
        {
            DialogResult result = MessageBox.Show("Close Calculator?", "Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);

                if (textBox.Text == "")
                {
                    functionPressed = false;
                    clearTB = false;
                    functionSwitch = 0;
                    newNum = 0;
                    oldNum = 0;
                    answer = 0;
                }
            }
        }
     

    }
}
