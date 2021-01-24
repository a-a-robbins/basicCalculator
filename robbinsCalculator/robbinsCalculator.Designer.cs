
namespace robbinsCalculator
{
    partial class robbinsCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtIO = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn1DivX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblEq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Location = new System.Drawing.Point(14, 361);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(252, 56);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btn_Calculate);
            // 
            // txtIO
            // 
            this.txtIO.Location = new System.Drawing.Point(14, 22);
            this.txtIO.Multiline = true;
            this.txtIO.Name = "txtIO";
            this.txtIO.Size = new System.Drawing.Size(252, 60);
            this.txtIO.TabIndex = 1;
            this.txtIO.Text = "0";
            this.txtIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIO.TextChanged += new System.EventHandler(this.txtIO_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(229, 101);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(37, 47);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btn_Clear);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 163);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(37, 47);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(57, 163);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(37, 47);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(100, 163);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 47);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(229, 163);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 47);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btn_Operator);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 47);
            this.button6.TabIndex = 9;
            this.button6.Text = "!!!";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(143, 227);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(37, 47);
            this.btnSquare.TabIndex = 10;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(100, 227);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 47);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(57, 227);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(37, 47);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(14, 227);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(37, 47);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(143, 163);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(37, 47);
            this.btnPow.TabIndex = 14;
            this.btnPow.Text = "x^y";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(57, 101);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(37, 47);
            this.btnSqrt.TabIndex = 15;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btn1DivX
            // 
            this.btn1DivX.Location = new System.Drawing.Point(100, 101);
            this.btn1DivX.Name = "btn1DivX";
            this.btn1DivX.Size = new System.Drawing.Size(37, 47);
            this.btn1DivX.TabIndex = 16;
            this.btn1DivX.Text = "1/x";
            this.btn1DivX.UseVisualStyleBackColor = true;
            this.btn1DivX.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(143, 101);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(37, 47);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btn_Clear);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(186, 101);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(37, 47);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btn_Clear);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(186, 227);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(37, 47);
            this.btnMult.TabIndex = 19;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(229, 227);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(37, 47);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(229, 294);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(37, 47);
            this.btnDec.TabIndex = 26;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(186, 294);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(37, 47);
            this.btnSign.TabIndex = 25;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(14, 294);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(37, 47);
            this.btn7.TabIndex = 24;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(57, 294);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(37, 47);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(100, 294);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 47);
            this.btn9.TabIndex = 22;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(143, 294);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(37, 47);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Location = new System.Drawing.Point(16, 25);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(0, 13);
            this.lblEq.TabIndex = 27;
            // 
            // robbinsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 444);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn1DivX);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtIO);
            this.Controls.Add(this.btnCalc);
            this.KeyPreview = true;
            this.Name = "robbinsCalculator";
            this.Text = "robbinsCalculator";
            this.Load += new System.EventHandler(this.robbinsCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtIO;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn1DivX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblEq;
    }
}

