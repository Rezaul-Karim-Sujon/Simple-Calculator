using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_1
{
    public partial class Form1 : Form
    {

        Double value = 0, final_value = 0,last_value;
        string operation = "",last_operation="";
        bool is_value_entered = false;
        //bool[] all_possible_bool = { false, false, false, false, false };
        string[] check_operator = { "+", "-", "X", "/", "MOD" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if((textBox_Display.Text=="0") || (is_value_entered))
            {
                textBox_Display.Text = "";
            }
            is_value_entered = false;
            /*for (int i=1;i<all_possible_bool.Length;i++) /// => kaj korle delete kormo
            {
                if(all_possible_bool[i])
                {
                    textBox_Display.Text = "";
                    value = 0;
                    break;
                }
            }
            for(int i=0;i<all_possible_bool.Length;i++)
            {
                all_possible_bool[i] = false; // kaj korle delete kormo
            }*/
            Button Num_obj = (Button)sender;
            
            if(Num_obj.Text==".")
            {
                if(!textBox_Display.Text.Contains("."))
                {
                    textBox_Display.Text = textBox_Display.Text + Num_obj.Text;
                }
            }
            else
            {
                textBox_Display.Text = textBox_Display.Text + Num_obj.Text;
            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_Display.Text = "0";
            textBox_Display.Text = "0";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_Display.Text = "0";
            final_value = value = 0;
            label_Show.Text = "";
        }

        private void button_Single_Erase_Click(object sender, EventArgs e)
        {
            if(textBox_Display.Text.Length>0)
            {
                textBox_Display.Text = textBox_Display.Text.Remove(textBox_Display.Text.Length - 1, 1);
            }
            if (textBox_Display.Text=="")
            {
                textBox_Display.Text = "0";
            }
        }

        private void Arithmatic_Operator(object sender, EventArgs e)
        {
            Button obj_operator = (Button)sender;
            if(value!=0)
            {
                all_calculation(sender, e);
            }
            operation = obj_operator.Text;
            try
            {
                value = Double.Parse(textBox_Display.Text);
            }
            catch
            {
                value = 0;
            }
            textBox_Display.Text = "";
            label_Show.Text = System.Convert.ToString(value) + " " + operation;
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            all_calculation(sender, e);
            try
            {
                value = Double.Parse(textBox_Display.Text);
            }
            catch
            {
                value = 0;
            }
            operation = "";
            is_value_entered = true;
        }
        private void all_calculation(object sender, EventArgs e)
        {
            label_Show.Text = "";
            Button obj_operator = (Button)sender;
            if (operation == "+")
            {
                last_operation = operation;
                try
                {
                    final_value= Double.Parse(textBox_Display.Text);
                    last_value = final_value;
                    value = value + final_value;
                    textBox_Display.Text = (value).ToString();
                }
                catch
                {
                    if (check_operator.Contains(obj_operator.Text))
                    {
                        operation = obj_operator.Text;
                        textBox_Display.Text = (value).ToString();
                    }
                    else if (obj_operator.Text == "=")
                    {
                        value += value;
                        textBox_Display.Text = (value).ToString();
                    }
                }
            }
            else if (operation == "-")
            {
                last_operation = operation;
                try
                {
                    final_value= Double.Parse(textBox_Display.Text);
                    last_value = final_value;
                    value = value-final_value;
                    textBox_Display.Text = (value).ToString();
                }
                catch
                {
                    if (check_operator.Contains(obj_operator.Text))
                    {
                        operation = obj_operator.Text;
                        textBox_Display.Text = (value).ToString();
                    }
                    else if (obj_operator.Text == "=")
                    {
                        value -= value;
                        textBox_Display.Text = (value).ToString();
                    }
                }
            }
            else if (operation == "X")
            {
                last_operation = operation;
                try
                {
                    final_value= Double.Parse(textBox_Display.Text);
                    last_value = final_value;
                    //value *= temp;
                    //all_possible_bool[0] = true;
                    value = value * final_value;
                    textBox_Display.Text = (value).ToString();
                }
                catch
                {
                    if (check_operator.Contains(obj_operator.Text))
                    {
                        operation = obj_operator.Text;
                        textBox_Display.Text = (value).ToString();
                    }
                    else if(obj_operator.Text=="=")
                    {
                        value *= value;
                        textBox_Display.Text = (value).ToString();
                    }
                }
            }
            else if (operation == "/")
            {
                double temp=0;
                last_operation = operation;
                try
                {
                    temp = Double.Parse(textBox_Display.Text);
                    last_value = temp;
                    if (temp != 0)
                    {
                        value =value/temp;
                        textBox_Display.Text = (value).ToString();
                    }
                    else
                    {
                        textBox_Display.Text = "Can not divide by zero";
                    }
                }
                catch
                {
                    if (check_operator.Contains(obj_operator.Text))
                    {
                        operation = obj_operator.Text;
                        textBox_Display.Text = (value).ToString();
                    }
                    else if (obj_operator.Text == "=")
                    {
                        value /= value;
                        textBox_Display.Text = (value).ToString();
                    }
                }
            }
            else if (operation == "MOD")
            {
                last_operation = operation;
                try
                {
                    final_value= Double.Parse(textBox_Display.Text);
                    last_value = final_value;
                    value =value % final_value;
                    textBox_Display.Text = (value).ToString();
                }
                catch
                {
                    if (check_operator.Contains(obj_operator.Text))
                    {
                        operation = obj_operator.Text;
                        textBox_Display.Text = (value).ToString();
                    }
                    else if (obj_operator.Text == "=")
                    {
                        value %= value;
                        textBox_Display.Text = (value).ToString();
                    }
                }
            }
            else if(operation=="=")
            {
                textBox_Display.Text = "";
            }
        }
        private void button_square_Click(object sender, EventArgs e)
        {
            Double power;
            try
            {
                power=Double.Parse(textBox_Display.Text);
            }
            catch
            {
                power = value;
            }
            label_Show.Text = Convert.ToString("(" + power + ")^2");
            power *= power;
            last_value = power;
            textBox_Display.Text = System.Convert.ToString(power);
            is_value_entered = true;
        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
            double sq;
            try 
            { 
                sq=Double.Parse(textBox_Display.Text);
            }
            catch
            {
                sq = value;
            }
            label_Show.Text = Convert.ToString("sqrt(" + sq + ")");
            sq = Math.Sqrt(sq);
            last_value = sq;
            //value=Math.Sqrt(sq);
            textBox_Display.Text = Convert.ToString(sq);
            is_value_entered = true;
        }

        private void button_inverse_Click(object sender, EventArgs e)
        {
            double invers;
            try
            {
                invers = Double.Parse(textBox_Display.Text);
            }
            catch
            {
                invers = value;
            }
            label_Show.Text = Convert.ToString("1/(" + invers +")");
            if(invers!=0)
            {
                invers = 1 / invers;
                textBox_Display.Text = Convert.ToString(invers);
            }
            else
            {
                textBox_Display.Text = "Cannot divide by zero";
            }
            is_value_entered = true;
        }

        private void button_plus_minus_Click(object sender, EventArgs e)
        {
            double pls_mns;
            try
            {
                pls_mns = Double.Parse(textBox_Display.Text) ;
            }
            catch
            {
                pls_mns = value;
            }
            pls_mns *= (-1);
            textBox_Display.Text = Convert.ToString(pls_mns);
        }
    }
}

 