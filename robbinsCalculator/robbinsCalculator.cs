using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robbinsCalculator
{
    public partial class robbinsCalculator : Form
    {
        float val1 = 0;
        String op = "";
        bool op_press = false;

        public robbinsCalculator()
        {
            InitializeComponent();
        }

       private void robbinsCalculator_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            KeyPress += robbinsCalculator_KeyPress;

        }
        private void robbinsCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
             switch ((int)e.KeyChar) // statement to handle each key press
            {
                case 48: // 0 
                         //want to save as an operand of the equation
                         //btn_Click(e.KeyChar, EventArgs e);
                    val1 = 0;                      
                    break; 
                case 49: //1
                    val1 = 1;
                    //e.Handled = true; 
                    break;
                case 50: //2
                    break;
                case 51: //3
                    break;
                case 52: //4
                    break; 
                case 53: //5
                    break;
                case 54: //6
                    break;
                case 55: //7
                    break;
                case 56: //8
                    break;
                case 57: //9
                    break; 


            }
     

        }


        private void btn_Click(object sender, EventArgs e)
        {
            if(txtIO.Text == "0" ||op_press == true)
            {
                txtIO.Clear(); 
            }
            op_press = false; 
            Button b = (Button)sender;
            if (b.Text == "pi")
            {
                val1 = 3.141592654F;
                txtIO.Text = "3.141592654";
            }
            else
            {
                txtIO.Text = txtIO.Text + b.Text;
            }
            
            
        }

        private void btn_Clear(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            switch(c.Text)
            {
                case "CE":
                    txtIO.Text = "0"; 
                    break;
                case "C":
                    txtIO.Clear();
                    txtIO.Text = "0"; 
                    break;
                case "Del":
                    //FIX ME: need to just backspace
                    break;
                default:
                    break; 
            }
        }

        private void btn_Operator(object sender, EventArgs e)
        {
            op_press = true;
            Button o = (Button)sender;
            op = o.Text;
            val1 = float.Parse(txtIO.Text);
            lblEq.Text = val1 + " " + op;
        }

        private void btn_Calculate(object sender, EventArgs e)
        {
            op_press = false;
            lblEq.Text = ""; 
            switch (op)
            {
                case "+":
                    txtIO.Text = (val1 + float.Parse(txtIO.Text)).ToString();
                    break;
                case "-":
                    txtIO.Text = (val1 - float.Parse(txtIO.Text)).ToString();
                    break;
                case "*":
                    txtIO.Text = (val1 * float.Parse(txtIO.Text)).ToString();
                    break;
                case "/":
                    if (float.Parse(txtIO.Text) == 0)
                    {
                        txtIO.Text = "Cannot divide by zero";
                        break;
                    }
                    txtIO.Text = (val1 / float.Parse(txtIO.Text)).ToString();
                    break;
                case "1/x":
                    if(val1 == 0)
                    {
                        txtIO.Text = "Cannot divide by zero";
                        break;
                    }
                    txtIO.Text = (1 / val1).ToString();
                    break;
                case "Sqrt": //FIX ME
                    if(val1 < 0)
                    {
                        txtIO.Text = "Sorry, we do not deal with i here :(";
                        break; 
                    }
                    txtIO.Text = Math.Sqrt(val1).ToString();
                    break;
                case "x^y":
                    txtIO.Text = (Math.Pow(val1, float.Parse(txtIO.Text))).ToString();
                    break;
                case "x^2":
                    txtIO.Text = (Math.Pow(val1, 2)).ToString();
                    break;
                case "+/-":
                    txtIO.Text = (val1 * (-1)).ToString();
                    break; 
                default:
                    break;
            }
            op_press = true; 
        }

        private void txtIO_TextChanged(object sender, EventArgs e)
        { 
        
        
        }
    }
}

