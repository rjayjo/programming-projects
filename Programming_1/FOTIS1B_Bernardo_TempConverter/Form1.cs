using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_TempConverter
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
            
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            // Celcius to Fahrenheit
            double inputTemp, convertedTemp;
            inputTemp = double.Parse(txtCelsiusInput.Text);
            convertedTemp = (inputTemp * 1.8 + 32);
            txtFahrenheitResult.Text = convertedTemp.ToString();

        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            // Fahrenheit to Celsius
            double inputTemp2, convertedTemp2;
            inputTemp2 = double.Parse(txtFahrenheitInput.Text);
            convertedTemp2 = (inputTemp2 - 32) *5 / 9;
            txtCelsiusResult.Text = convertedTemp2.ToString();
        }
    }
}
