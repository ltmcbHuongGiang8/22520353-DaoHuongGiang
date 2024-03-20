using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520353
{
    public partial class Lab01_Bai03 : Form
    {
        string[] name = new string[]  { "Khong", "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin" };
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num = int.Parse(textBox1.Text.Trim());
            //textBox2.Text = name[num];
            if (int.TryParse(textBox1.Text.Trim(), out int num) && num >= 0 && num <= 9)
            {
                textBox2.Text = name[num];
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số từ 0 đến 9.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lab01_Bai03_Load(object sender, EventArgs e)
        {

        }
    }
}
