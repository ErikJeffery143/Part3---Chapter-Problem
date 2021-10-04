using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part3___Chapter_Problem
{
    public partial class BasicInput : Form
    {
        public BasicInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            double height;
            double tallest = 2.72;

            name = txtName.Text;
            age = Convert.ToInt32(numAge.Text);
            height = Convert.ToDouble(txtHeight.Text);


            lblTotal.Text = " Hello, " + name + " who is " + age + " years old, You are " + (tallest - height) + "M  shorter then the tallest person to ever live.";



            {

            }


        }
    }
}
