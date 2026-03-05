using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_DigitReversal
{
    public partial class frmDRC : Form
    {
        public frmDRC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            int numOriginal, numReversed = 0, remainder;
            numOriginal = Convert.ToInt32(txtOriginal.Text);
 
            while (numOriginal > 0)
            {
                remainder = numOriginal % 10;
                numReversed = numReversed * 10 + remainder;
                numOriginal = numOriginal / 10;
                txtReversed.Text = numReversed.ToString();
            }
        }

        private void btnInitiate_MouseEnter(object sender, EventArgs e)
        {
            btnInitiate.Text = "Proceed?";
        }

        private void btnInitiate_MouseLeave(object sender, EventArgs e)
        {
            btnInitiate.Text = "Initiate Reversal";
        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
        }
    }
    }

