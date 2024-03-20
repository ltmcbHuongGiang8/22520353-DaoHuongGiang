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
    public partial class Lab01_Bai31 : Form
    {
        public Lab01_Bai31()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] chuSo = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

            string input = textBox1.Text.Trim();
            input = System.Text.RegularExpressions.Regex.Replace(input, "[^0-9]", "");

            if (input.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập một số có 12 chữ số.");
                return;
            }

            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                int num = int.Parse(input[i].ToString());

                if (num == 0 && i % 3 != 0 && i < 11 && input[i + 1] != '0')
                {
                    result += chuSo[num] + " linh ";
                }
                else if (num == 0 && i % 3 == 0 && i < 11)
                {
                    result += chuSo[num] + " trăm ";
                }
                else if (num == 0 && i == 11)
                {
                    result += chuSo[num];
                }
                else
                {
                    switch (i % 3)
                    {
                        case 0:
                            result += chuSo[num] + " trăm ";
                            break;
                        case 1:
                            if (num == 1)
                            {
                                result += "mười ";
                            }
                            else
                            {
                                result += chuSo[num] + " mươi ";
                            }
                            break;
                        case 2:
                            if (num != 0)
                            {
                                result += chuSo[num];
                            }
                            if (i < 11)
                            {
                                if (input[i + 1] != '0')
                                {
                                    result += " ngàn ";
                                }
                                else if (input[i + 1] == '0' && input[i + 2] != '0')
                                {
                                    result += " trăm ";
                                }
                            }
                            break;
                    }
                }
            }

            textBox2.Text = result;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
