using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22520353
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void Lab01_Bai05_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bảng Cửu Chương");
            comboBox1.Items.Add("Tính Toán");
        }
        private int CheckSelection()
        {
            string selectedOption = comboBox1.SelectedItem as string;
            if (selectedOption == null)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn.");
                return 0;
            }
            else if (selectedOption == "Bảng Cửu Chương")
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
        private int LuyThua(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * LuyThua(n - 1);
        }
        private int TinhSum(int baseNumber, int power)
        {
            int result = 0;
            for (int i = 1; i <= power; i++)
            {
                result += (int)Math.Pow(baseNumber, i);
            }
            return result;
        }
        private void ShowBCC(int times)
        {
            string result = "";
            for (int i = 1; i <= 10; i++)
            {
                result += $"{times} x {i} = {times * i}\r\n";
            }
            textBoxResult.Text = result;
        }

        // Hàm hiển thị kết quả giai thừa hoặc tổng các lũy thừa
        private void ShowFactorialOrPowerSumResult(int factorialResult, int sumResult)
        {
            textBoxResult.Text = $"(A - B)!: {factorialResult}\r\nTổng S: {sumResult}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int option = CheckSelection();
            if (option == 1)
            {
                int A, B;
                if (int.TryParse(textBox1.Text, out A) && int.TryParse(textBox2.Text, out B))
                {
                    ShowBCC(B - A);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
                }
            }
            else if (option == 2)
            {
                int A, B;
                if (int.TryParse(textBox1.Text, out A) && int.TryParse(textBox2.Text, out B))
                {
                    if (A < B)
                    {
                        string selectedOption = comboBox1.SelectedItem as string;
                        int factorialResult = LuyThua(B - A);
                        int sumResult = TinhSum(A, B);
                        ShowFactorialOrPowerSumResult(factorialResult, sumResult);
                    }

                    else
                    {
                        MessageBox.Show("Lựa chọn không hợp lệ: A phải nhỏ hơn B để tính (A - B)!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

