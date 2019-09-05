using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        //global variable
        float result;
        bool isOperationPerfomed;
        string operationPerformed;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isOperationPerfomed == true || textBoxResult.Text == "0")
                textBoxResult.Clear();

            isOperationPerfomed = false;

            Button button = (Button)sender;
            if (button.Text != "." || (button.Text == "." && textBoxResult.Text.Contains(".") == false))
                textBoxResult.Text += button.Text;
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            result = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    {
                        textBoxResult.Text = (result + float.Parse(textBoxResult.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        textBoxResult.Text = (result - float.Parse(textBoxResult.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        textBoxResult.Text = (result * float.Parse(textBoxResult.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        textBoxResult.Text = (result / float.Parse(textBoxResult.Text)).ToString();
                        break;
                    }
            }

            result = float.Parse(textBoxResult.Text);
            labelCurrentResult.Text = "";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result == 0)
            {
                operationPerformed = button.Text;
                result = float.Parse(textBoxResult.Text);
                labelCurrentResult.Text = result + " " + operationPerformed;
                isOperationPerfomed = true;
            }
            else
            {
                button22.PerformClick();
                operationPerformed = button.Text;
                labelCurrentResult.Text = result + " " + operationPerformed;
                isOperationPerfomed = true;
            }
        }
    }
}
