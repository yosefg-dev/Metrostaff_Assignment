/*using MathOperation;*/
using metrostaff.Controllers;
/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;*/

namespace metrostaff
{
    public partial class Calculator : Form
    {
        int oprand;
        AdvancedMath mathobj = new AdvancedMath();
        public Calculator()
        {
            InitializeComponent();
        }
        //*******Basic Arthimentic Functions Add, Sub, Mul, Div, Pow ------
        //which have two arguments or oprands********//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            oprand = 1;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            oprand = 2;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            oprand = 3;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oprand = 4;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            oprand = 5;
        }
        //=======================Basic Arthimentic Functions
        //*******Trignometric Functions Sin, Cos, Tan, ASin, ACos, ATan********//
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Sin(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Sin Operation", ex.Message);
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Cos(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Cos Operation", ex.Message);
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Tan(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Tan Operation", ex.Message);
            }
        }

        private void btnAsin_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Asin(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Asin Operation", ex.Message);
            }
        }

        private void btnAcos_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Acos(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Acos Operation", ex.Message);
            }
        }

        private void btnAtan_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Atan(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Atan Operation", ex.Message);
            }
        }
        //===========End of Trignometric Functions ==============//

        //*******Basic Arthimentic Functions manupulation after = sign clicked *****
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (oprand)
            {
                case 1:
                    try
                    {
                        txtBox.Text = AdvancedMath.Add(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error on Addition", ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        txtBox.Text = AdvancedMath.Subtract(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error on Subtruction", ex.Message);
                    }
                    break;
                case 3:
                    try { 
                        txtBox.Text = AdvancedMath.Multiply(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error on Multiply", ex.Message);
                    }
                    break ;
                case 4:
                    try
                    {
                        txtBox.Text = AdvancedMath.Divide(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error on Division", ex.Message);
                    }
                        break;
                case 5:
                    try
                    {
                        txtBox.Text = AdvancedMath.PowerOf(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error on Power Off", ex.Message);
                    }
                    break;
            }
        }

        //=============End of Basic Arthimethic Operation===========

        //************sqrt of a number *****************
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = AdvancedMath.Sqrt(double.Parse(textBox1.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //************Leonardo Fibonacci
        //Matematico italiano

        //*****************
        private void btnfib_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox.Text = mathobj.Fibonacci(int.Parse(textBox1.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //************Reset the text areas in the calculator  *****************
        private void btnCls_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            txtBox.Text = string.Empty;
        }
    }

       
    }
