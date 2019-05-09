using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertLab3ScharpToGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region TextBoxs
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Labels
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons
        private void plus_button_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();
            try
            {
                int getnum1;
                int getden1;
                int getnum2;
                int getden2;
                getnum1 = int.Parse(textBox1.Text);
                getden1 = int.Parse(textBox2.Text);
                getnum2 = int.Parse(textBox3.Text);
                getden2 = int.Parse(textBox4.Text);
                if (getden1 == 0 || getden2 == 0)
                {
                    MessageBox.Show("В знаменателе одной из дробей имеется ноль");
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    f1.numerator = getnum1;
                    f1.denominator = getden1;
                    f2.numerator = getnum2;
                    f2.denominator = getden2;
                    f3 = f1 + f2;
                    textBox5.Text = Convert.ToString(f3.numerator);
                    textBox6.Text = Convert.ToString(f3.denominator);
                    label10.Text = "+";
                    label5.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Числитель и/или знаменатель не содержат значений, или же введенные вами символы не являются числами");
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();
            try
            {
                int getnum1;
                int getden1;
                int getnum2;
                int getden2;
                getnum1 = int.Parse(textBox1.Text);
                getden1 = int.Parse(textBox2.Text);
                getnum2 = int.Parse(textBox3.Text);
                getden2 = int.Parse(textBox4.Text);
                if (getden1 == 0 || getden2 == 0)
                {
                    MessageBox.Show("В знаменателе одной из дробей имеется ноль");
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    f1.numerator = getnum1;
                    f1.denominator = getden1;
                    f2.numerator = getnum2;
                    f2.denominator = getden2;
                    f3 = f1 - f2;
                    textBox5.Text = Convert.ToString(f3.numerator);
                    textBox6.Text = Convert.ToString(f3.denominator);
                    label10.Text = "-";
                    label5.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Числитель и/или знаменатель не содержат значений, или же введенные вами символы не являются числами");
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();
            try
            {
                int getnum1;
                int getden1;
                int getnum2;
                int getden2;
                getnum1 = int.Parse(textBox1.Text);
                getden1 = int.Parse(textBox2.Text);
                getnum2 = int.Parse(textBox3.Text);
                getden2 = int.Parse(textBox4.Text);
                if (getden1 == 0 || getden2 == 0)
                {
                    MessageBox.Show("В знаменателе одной из дробей имеется ноль");
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    f1.numerator = getnum1;
                    f1.denominator = getden1;
                    f2.numerator = getnum2;
                    f2.denominator = getden2;
                    f3 = f1 * f2;
                    textBox5.Text = Convert.ToString(f3.numerator);
                    textBox6.Text = Convert.ToString(f3.denominator);
                    label10.Text = "*";
                    label5.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Числитель и/или знаменатель не содержат значений, или же введенные вами символы не являются числами");
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction();
            try
            {
                int getnum1;
                int getden1;
                int getnum2;
                int getden2;
                getnum1 = int.Parse(textBox1.Text);
                getden1 = int.Parse(textBox2.Text);
                getnum2 = int.Parse(textBox3.Text);
                getden2 = int.Parse(textBox4.Text);
                if (getden1 == 0 || getden2 == 0)
                {
                    MessageBox.Show("В знаменателе одной из дробей имеется ноль");
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
                else
                {
                    f1.numerator = getnum1;
                    f1.denominator = getden1;
                    f2.numerator = getnum2;
                    f2.denominator = getden2;
                    f3 = f1 / f2;
                    textBox5.Text = Convert.ToString(f3.numerator);
                    textBox6.Text = Convert.ToString(f3.denominator);
                    label10.Text = "/";
                    label5.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Числитель и/или знаменатель не содержат значений, или же введенные вами символы не являются числами");
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void collation1_button_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            try
            {
                int getnum1;
                int getden1;
                getnum1 = int.Parse(textBox1.Text);
                getden1 = int.Parse(textBox2.Text);
                int getnum2;
                int getden2;
                getnum2 = int.Parse(textBox3.Text);
                getden2 = int.Parse(textBox4.Text);
                f1.numerator = getnum1;
                f1.denominator = getden1;
                f2.numerator = getnum2;
                f2.denominator = getden2;
                if (f1 > f2)
                {
                    label10.Text = ">";
                }
                else
                {
                    label10.Text = "<";
                }
                if (f1 == f2)
                {
                    label10.Text = "=";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Введенные вами значения некорректны и не подлежат сравнению");
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.label1.Text = "";
            this.label2.Text = "";
            this.label6.Text = "";
            this.label5.Text = "";
            this.label10.Text = "";
            this.label12.Text = "";
            this.label13.Text = "";

            FocusInputText();
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            FractionMethod();
            /*
            try
            {
                int getnum1;
                int getden1;
                getnum1 = int.Parse(textBox5.Text);
                getden1 = int.Parse(textBox6.Text);
                label13.Text = Convert.ToString(Math.Round(((double)getnum1 / (double)getden1), 5));
                label12.Text = "=";
            }
            catch (FormatException)
            {
                MessageBox.Show("Нет результата для представления");
            }
            */
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FractionMethod()
        {
            try
            {
                int getnum1;
                int getden1;
                if(textBox5.Text == "" || textBox6.Text == "")
                {
                    label12.Text = "";
                    label13.Text = "";
                }
                else
                {
                    getnum1 = int.Parse(textBox5.Text);
                    getden1 = int.Parse(textBox6.Text);
                    label13.Text = Convert.ToString(Math.Round(((double)getnum1 / (double)getden1), 5));
                    label12.Text = "=";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Нет результата для представления");
            }
        }

        private void FocusInputText()
        {

        }
    }
}