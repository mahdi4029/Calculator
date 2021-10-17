using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private ICalculate _calculate;
        public Form1()
        {
            _calculate = new Calculate();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool Validator()
        {
            bool IsValid = true;

            if (nudNumber1.Value==0)
            {
                IsValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }

            else
            {
                if (nudNumber2.Value==0)
                {
                    IsValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }

            return IsValid;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
               MessageBox.Show(_calculate.Plus((int)nudNumber1.Value, (int)nudNumber2.Value).ToString());
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                MessageBox.Show(_calculate.Minus((int)nudNumber1.Value, (int)nudNumber2.Value).ToString());
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                MessageBox.Show(_calculate.Division((int)nudNumber1.Value, (int)nudNumber2.Value).ToString());
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                MessageBox.Show(_calculate.Multiplication((int)nudNumber1.Value, (int)nudNumber2.Value).ToString());
            }
        }
    }
}
