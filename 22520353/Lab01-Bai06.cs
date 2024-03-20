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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void Lab01_Bai06_Load(object sender, EventArgs e)
        {

        }

       
        private string XacDinhCHD(int day, int month)
        {
            // Dùng switch case để xác định cung hoàng đạo
            switch (month)
            {
                case 1:
                    return (day <= 19) ? "Ma Kết" : "Bảo Bình";
                case 2:
                    return (day <= 19) ? "Bảo Bình" : "Song Ngư";
                case 3:
                    return (day <= 20) ? "Song Ngư" : "Bạch Dương";
                case 4:
                    return (day <= 20) ? "Bạch Dương" : "Kim Ngưu";
                case 5:
                    return (day <= 21) ? "Kim Ngưu" : "Song Tử";
                case 6:
                    return (day <= 21) ? "Song Tử" : "Cự Giải";
                case 7:
                    return (day <= 22) ? "Cự Giải" : "Sư Tử";
                case 8:
                    return (day <= 22) ? "Sư Tử" : "Xử Nữ";
                case 9:
                    return (day <= 23) ? "Xử Nữ" : "Thiên Bình";
                case 10:
                    return (day <= 23) ? "Thiên Bình" : "Thần Nông";
                case 11:
                    return (day <= 22) ? "Thần Nông" : "Nhân Mã";
                case 12:
                    return (day <= 21) ? "Nhân Mã" : "Ma Kết";
                default:
                    return "Không xác định"; // Trong trường hợp nhập liệu không hợp lệ
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy ngày tháng năm từ DateTimePicker
            DateTime birthDate = dateTimePicker1.Value;

            // Tính toán cung hoàng đạo
            string zodiacSign = XacDinhCHD(birthDate.Day, birthDate.Month);

            // Xuất thông tin cung hoàng đạo
            MessageBox.Show($"Cung hoàng đạo của bạn là: {zodiacSign}", "Thông tin cung hoàng đạo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
