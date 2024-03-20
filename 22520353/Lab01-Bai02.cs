using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520353
{
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2, str3;
            str1 = textBox1.Text.Trim();
            str2 = textBox2.Text.Trim();
            str3 = textBox3.Text.Trim();

            double num1, num2, num3;
            if (double.TryParse(str1, out num1) && double.TryParse(str2, out num2) && double.TryParse(str3, out num3))
            {
                double mini, maxi;
                mini = maxi = num1;
                if (num2 < mini) mini = num2;
                if (num3 < mini) mini = num3;
                if (num2 > maxi) maxi = num2;
                if (num3 > maxi) maxi = num3;
                textBox4.Text = mini.ToString();
                textBox5.Text = maxi.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại số");
            }


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
