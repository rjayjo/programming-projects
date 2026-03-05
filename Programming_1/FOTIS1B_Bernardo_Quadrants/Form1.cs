using System;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_Quadrants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            double x, y;
            bool y1;
            string q1 = ("Quadrant I");
            string q2 = ("Quadrant II");
            string q3 = ("Quadrant III");
            string q4 = ("Quadrant IV");
            string xAxis = ("X-Axis");
            string yAxis = ("Y-Axis");
            string origin = ("Origin");

            if (txtX.Text == "") // To check if there are empty entries for the X-Coordinate Field
            {
                MessageBox.Show("You can't leave X-Coordinate field as blank.");
                return;
            }

            y1 = double.TryParse(txtY.Text, out y); // To check if valid numerical input is typed for Y-Coordinate Field

            if (y1 == false)
            {
                MessageBox.Show("Please input a real number for Y-Coordinate field.");
                txtY.Clear();
                return;
            }


            x = double.Parse(txtX.Text);
            y = double.Parse(txtY.Text);


            if (x == +x | x > 0 && y == +y | y > 0) // Quadrant 1
            {
                txtQ.Text = q1;
            }

            if (x == -x | x < 0 && y == +y | y > 0) // Quadrant 2
            {
                txtQ.Text = q2;
            }

            if (x == -x | x < 0 && y == -y | y < 0) // Quadrant 3
            {
                txtQ.Text = q3;
            }

            if (x > 0 && y < 0) // Quadrant 4
            {
                txtQ.Text = q4;
            }

            if (x == +x | x == -x && y == 0) // X-Axis
            {
                txtQ.Text = xAxis;
            }

            if (x == 0 && y == +y | y == -y) // Y-Axis
            {
                txtQ.Text = yAxis;
            }

            if (x == 0 & y == 0)
            {
                txtQ.Text = origin;

            }

        }

    }

}
