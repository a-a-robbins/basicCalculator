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
             switch ((int)e.KeyChar) 
            {
                case 48: // 0 
                         
                    btn0.PerformClick();                      
                    break; 
                case 49: //1
                    btn1.PerformClick();
                    break;
                case 50: //2
                    btn2.PerformClick();
                    break;
                case 51: //3
                    btn3.PerformClick();
                    break;
                case 52: //4
                    btn4.PerformClick();
                    break; 
                case 53: //5
                    btn5.PerformClick(); 
                    break;
                case 54: //6
                    btn6.PerformClick(); 
                    break;
                case 55: //7
                    btn7.PerformClick();
                    break;
                case 56: //8
                    btn8.PerformClick();
                    break;
                case 57: //9
                    btn9.PerformClick();
                    break;
                case 42: //*
                    btnMult.PerformClick();
                    break;
                case 43: //+
                    btnAdd.PerformClick();
                    break;
                case 45: //-
                    btnMinus.PerformClick();
                    break;
                case 46: //.
                    btnDec.PerformClick();
                    break;
                case 47: // /
                    btnDiv.PerformClick();
                    break;
                case 2386: //Enter key
                    btnCalc.PerformClick();
                    break;
                case 8: //Bkspc
                    btnDel.PerformClick(); 
                    break;
                default:
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
                    lblEq.Text = " "; 
                    txtIO.Text = "0"; 
                    break;
                case "Del":
                    //txtIO.Text = txtIO.Text.Remove(txtIO.Text.Length - 1); 
                    int x = txtIO.TextLength - 1;
                    //txtIO.Text = txtIO.Text.Replace(x, null); 
                    break;
                default:
                    break; 
            }
        }

        private void btn_Operator(object sender, EventArgs e)
        {
            Button o = (Button)sender;
            if (val1 != 0)
            {
                btnCalc.PerformClick();
                op_press = true;
                op = o.Text;
                lblEq.Text = val1 + " " + op;
            }
            else
            {
                op_press = true;
                op = o.Text;
                val1 = float.Parse(txtIO.Text);
                lblEq.Text = val1 + " " + op;
            }
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
                case "sqrt": //FIX ME
                    if(val1 < 0)
                    {
                        txtIO.Text = "Sorry, we do not deal with i here :(";
                        break; 
                    }
                    txtIO.Text = (Math.Sqrt(val1)).ToString();
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
            val1 = float.Parse(txtIO.Text);
            op = ""; 
            op_press = true; 
        }

        private void txtIO_TextChanged(object sender, EventArgs e)
        { 
        
        
        }
    }
}

