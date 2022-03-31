using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        string input1 = "";
        string input2 = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            calcDisplay.Text = "";
            userInput += "1";
            calcDisplay.Text += userInput;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "2";
            calcDisplay.Text += userInput;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "3";
            calcDisplay.Text += userInput;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "4";
            calcDisplay.Text += userInput;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "5";
            calcDisplay.Text += userInput;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "6";
            calcDisplay.Text += userInput;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "7";
            calcDisplay.Text += userInput;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "8";
            calcDisplay.Text += userInput;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "9";
            calcDisplay.Text += userInput;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "0";
            calcDisplay.Text += userInput;

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            function = '+';
            input1 = userInput;
            userInput = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            function = '-';
            input1 = userInput;
            userInput = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            function = '*';
            input1 = userInput;
            userInput = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            input1 = userInput;
            userInput = "";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "";
            userInput += ".";
            calcDisplay.Text += userInput;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input1 = "";
            input2 = "";
            userInput = "";
            result = 0.0;
            calcDisplay.Text = "0";
            
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            input2 = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(input1);
            secondNum = Convert.ToDouble(input2);

            if(function == '+')
            {
                result = firstNum + secondNum;
                calcDisplay.Text = result.ToString();
            }
            else if(function == '-')
            {
                result = firstNum - secondNum;
                calcDisplay.Text = result.ToString();
            }
            else if(function == '*')
            {
                result = firstNum * secondNum;
                calcDisplay.Text = result.ToString();
            }
            else if(function == '/')
            {
                if(secondNum == 0)
                {
                    calcDisplay.Text = "No zero division";
                }
                else
                {
                    result = firstNum / secondNum;
                    calcDisplay.Text = result.ToString();
                }
            }
        }
    }
}
