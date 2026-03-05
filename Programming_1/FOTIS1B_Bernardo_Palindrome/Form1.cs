using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string word, reversedword;
            int numberOfLetters;

            word = txtWord.Text.ToLower();
            reversedword = "";
            for (numberOfLetters = word.Length - 1; numberOfLetters >= 0; numberOfLetters-- )
            {
                reversedword += word[numberOfLetters];
            }
            
           if (word == reversedword)
            {
                MessageBox.Show("Palindrome");
                return;
            }
           else
            {
                MessageBox.Show("Not Palindrome");
                return;
            }
           



        }
    }
}
