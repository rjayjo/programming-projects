using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
           : 0 = 0,  1 = 1; 10 = 55

           int Fibonacci(int sequenceNum )
       {
           if (sequenceNum == 1 || sequenceNum == 2)
           {
               return 1;
           }
           else
           {
               return (Fibonacci(sequenceNum - 1)) + Fibonacci(sequenceNum - 2);

        }
      */

        /*
         
         : 0 = 0, 1 = 1; 10 = 55

            int Fibonacci (int sequenceNum)
         { 
            if (sequenceNum == 0 || n == 1)
               {
                    return sequenceNum;
               {
        else
            {
               return (Fibonacci(sequenceNum - 1)) + Fibonacci(sequenceNum - 2);
            }
        */

        int Fibo(int sequenceNum)
        {
            // 1 = 0; 10 = 34
            if (sequenceNum == 1)
            {
                return 0;
            }
            else if (sequenceNum == 2)
            {
                return 1;
            }
            else
            {
                return Fibo(sequenceNum - 1) + Fibo(sequenceNum - 2);
            }

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int seqNum = int.Parse(txtNo.Text);
            txtValue.Text = Fibo(seqNum).ToString();


        }

        

    }
}


