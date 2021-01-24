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
        Double val1 = 0;
        String op = "";
        bool op_press = false;

        public robbinsCalculator()
        {
            InitializeComponent();
        }

       private void robbinsCalculator_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            //KeyPress += robbinsCalculator_KeyPress;

        }

       
        private void btn_Click(object sender, EventArgs e)
        {
            if(txtIO.Text == "0" ||op_press == true)
            {
                txtIO.Clear(); 
            }
            op_press = false; 
            Button b = (Button)sender;
            txtIO.Text = txtIO.Text + b.Text;
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
            val1 = Double.Parse(txtIO.Text);
            lblEq.Text = val1 + " " + op;
        }

        private void btn_Calculate(object sender, EventArgs e)
        {
            op_press = false;
            lblEq.Text = ""; 
            switch (op)
            {
                case "+":
                    txtIO.Text = (val1 + Double.Parse(txtIO.Text)).ToString(); 
                    break;
                case "-":
                    txtIO.Text = (val1 - Double.Parse(txtIO.Text)).ToString();
                    break;
                case "*":
                    txtIO.Text = (val1 * Double.Parse(txtIO.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(txtIO.Text) == 0)
                    {
                        txtIO.Text = "Cannot divide by zero";
                        break;
                    }
                    txtIO.Text = (val1 / Double.Parse(txtIO.Text)).ToString();
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
                    txtIO.Text = Math.Sqrt(val1).ToString();
                    break;
                case "x^y":
                    txtIO.Text = (Math.Pow(val1, Double.Parse(txtIO.Text))).ToString();
                    break;
                case "x^2":
                    txtIO.Text = (Math.Pow(val1, 2)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void txtIO_TextChanged(object sender, EventArgs e)
        { 
        
        
        }




        /*private void robbinsCalculator_KeyPress(object sender, KeyPressEventArgs e)
       {
           //throw new NotImplementedException();
           switch ((int)e.KeyChar) // statement to handle each key press
           {
               case 48: //ascii code = 0 
                   //want to save as an operand of the equation
                   break; //need break statement so it doesn't accidentally run other statements
               case 105: //ascii code = i
                   break;
                   // case 55: //ascii code = 7

           }

       }*/
    }
}

