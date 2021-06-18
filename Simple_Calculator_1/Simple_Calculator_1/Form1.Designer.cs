
namespace Simple_Calculator_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Single_Erase = new System.Windows.Forms.Button();
            this.button_inverse = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.buttonsqrt = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button_plus_minus = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.textBox_Display = new System.Windows.Forms.TextBox();
            this.label_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 74);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "MOD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Arithmatic_Operator);
            // 
            // button_CE
            // 
            this.button_CE.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CE.Location = new System.Drawing.Point(178, 181);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(131, 74);
            this.button_CE.TabIndex = 1;
            this.button_CE.TabStop = false;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(317, 181);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(131, 74);
            this.button_C.TabIndex = 1;
            this.button_C.TabStop = false;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Single_Erase
            // 
            this.button_Single_Erase.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Single_Erase.Location = new System.Drawing.Point(457, 181);
            this.button_Single_Erase.Name = "button_Single_Erase";
            this.button_Single_Erase.Size = new System.Drawing.Size(131, 74);
            this.button_Single_Erase.TabIndex = 1;
            this.button_Single_Erase.TabStop = false;
            this.button_Single_Erase.Text = "<==";
            this.button_Single_Erase.UseVisualStyleBackColor = true;
            this.button_Single_Erase.Click += new System.EventHandler(this.button_Single_Erase_Click);
            // 
            // button_inverse
            // 
            this.button_inverse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inverse.Location = new System.Drawing.Point(39, 255);
            this.button_inverse.Name = "button_inverse";
            this.button_inverse.Size = new System.Drawing.Size(131, 74);
            this.button_inverse.TabIndex = 1;
            this.button_inverse.TabStop = false;
            this.button_inverse.Text = "1/x";
            this.button_inverse.UseVisualStyleBackColor = true;
            this.button_inverse.Click += new System.EventHandler(this.button_inverse_Click);
            // 
            // button_square
            // 
            this.button_square.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_square.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_square.Location = new System.Drawing.Point(178, 255);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(131, 74);
            this.button_square.TabIndex = 1;
            this.button_square.TabStop = false;
            this.button_square.Text = "x^2";
            this.button_square.UseVisualStyleBackColor = false;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // buttonsqrt
            // 
            this.buttonsqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonsqrt.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsqrt.Location = new System.Drawing.Point(317, 255);
            this.buttonsqrt.Name = "buttonsqrt";
            this.buttonsqrt.Size = new System.Drawing.Size(131, 74);
            this.buttonsqrt.TabIndex = 1;
            this.buttonsqrt.TabStop = false;
            this.buttonsqrt.Text = "sqrt(x)";
            this.buttonsqrt.UseVisualStyleBackColor = false;
            this.buttonsqrt.Click += new System.EventHandler(this.buttonsqrt_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(457, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 74);
            this.button8.TabIndex = 1;
            this.button8.TabStop = false;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Arithmatic_Operator);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(39, 328);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 74);
            this.button9.TabIndex = 1;
            this.button9.TabStop = false;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(178, 328);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 74);
            this.button10.TabIndex = 1;
            this.button10.TabStop = false;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(317, 328);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 74);
            this.button11.TabIndex = 1;
            this.button11.TabStop = false;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(457, 328);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 74);
            this.button12.TabIndex = 1;
            this.button12.TabStop = false;
            this.button12.Text = "X";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Arithmatic_Operator);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(39, 401);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(131, 74);
            this.button13.TabIndex = 1;
            this.button13.TabStop = false;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(178, 401);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(131, 74);
            this.button14.TabIndex = 1;
            this.button14.TabStop = false;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(317, 401);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(131, 74);
            this.button15.TabIndex = 1;
            this.button15.TabStop = false;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(457, 401);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(131, 74);
            this.button16.TabIndex = 1;
            this.button16.TabStop = false;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Arithmatic_Operator);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(39, 477);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(131, 74);
            this.button17.TabIndex = 1;
            this.button17.TabStop = false;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(178, 477);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(131, 74);
            this.button18.TabIndex = 1;
            this.button18.TabStop = false;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(317, 477);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(131, 74);
            this.button19.TabIndex = 1;
            this.button19.TabStop = false;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(457, 477);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(131, 74);
            this.button20.TabIndex = 1;
            this.button20.TabStop = false;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Arithmatic_Operator);
            // 
            // button_plus_minus
            // 
            this.button_plus_minus.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_minus.Location = new System.Drawing.Point(39, 553);
            this.button_plus_minus.Name = "button_plus_minus";
            this.button_plus_minus.Size = new System.Drawing.Size(131, 74);
            this.button_plus_minus.TabIndex = 1;
            this.button_plus_minus.TabStop = false;
            this.button_plus_minus.Text = "+-";
            this.button_plus_minus.UseVisualStyleBackColor = true;
            this.button_plus_minus.Click += new System.EventHandler(this.button_plus_minus_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(178, 553);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(131, 74);
            this.button22.TabIndex = 1;
            this.button22.TabStop = false;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(317, 553);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(131, 74);
            this.button23.TabIndex = 1;
            this.button23.TabStop = false;
            this.button23.Text = ".";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_equal
            // 
            this.button_equal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(457, 552);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(131, 74);
            this.button_equal.TabIndex = 1;
            this.button_equal.TabStop = false;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // textBox_Display
            // 
            this.textBox_Display.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Display.Location = new System.Drawing.Point(39, 66);
            this.textBox_Display.Name = "textBox_Display";
            this.textBox_Display.Size = new System.Drawing.Size(549, 73);
            this.textBox_Display.TabIndex = 2;
            this.textBox_Display.TabStop = false;
            this.textBox_Display.Text = "0";
            this.textBox_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Show
            // 
            this.label_Show.AutoSize = true;
            this.label_Show.Location = new System.Drawing.Point(39, 43);
            this.label_Show.Name = "label_Show";
            this.label_Show.Size = new System.Drawing.Size(0, 17);
            this.label_Show.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 647);
            this.Controls.Add(this.label_Show);
            this.Controls.Add(this.textBox_Display);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button_Single_Erase);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button_plus_minus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.buttonsqrt);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button_square);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_inverse);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Single_Erase;
        private System.Windows.Forms.Button button_inverse;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button buttonsqrt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button_plus_minus;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBox_Display;
        private System.Windows.Forms.Label label_Show;
        private System.Windows.Forms.Button button_equal;
    }
}

