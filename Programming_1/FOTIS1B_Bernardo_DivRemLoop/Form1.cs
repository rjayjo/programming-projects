using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_DivRemLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int dividend, divisor, quotient = 0, remainder;
            dividend = int.Parse(txtDividend.Text);
            divisor = int.Parse(txtDivisor.Text);

            if (dividend < divisor)
            {
                MessageBox.Show("The divisor cannot be higher than the dividend for this program");
            }

            if (dividend >= divisor)
            {
                while (dividend >= divisor)
                {
                    dividend = dividend - divisor;
                    quotient++;
                }

                {
                    remainder = dividend;
                    txtQuotient.Text = quotient.ToString();
                    txtRemainder.Text = remainder.ToString();
                }
            
            }

        }
    }
}
