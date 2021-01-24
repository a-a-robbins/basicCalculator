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
        Double val2 = 0;
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

        }
        private void btn_Click(object sender, EventArgs e)
        {
            if(txtIO.Text == "0")
            {
                txtIO.Clear(); 
            }
            Button b = (Button)sender;
            txtIO.Text = txtIO.Text + b.Text;
        }
        
    }
}

