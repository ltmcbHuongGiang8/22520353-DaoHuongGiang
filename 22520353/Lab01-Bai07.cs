using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22520353
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void Lab01_Bai07_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Loại bỏ các khoảng trắng không mong muốn và tách chuỗi đầu vào thành các phần tử
            string[] inputElements = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(element => element.Trim())
                                           .ToArray();

            // Kiểm tra tính hợp lệ của đầu vào
            if (inputElements.Length < 2 || (inputElements.Length - 1) % 2 != 0)
            {
                MessageBox.Show("Định dạng đầu vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin tên sinh viên và điểm từ mảng
            string studentName = inputElements[0];
            double[] scores = new double[(inputElements.Length - 1) ];
            for (int i = 0; i < scores.Length; i++)
            {
                if (!double.TryParse(inputElements[i + 1], out scores[i]))
                {
                    MessageBox.Show("Định dạng điểm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DisplayResult(studentName, scores);
        }

        private void DisplayResult(string studentName, double[] scores)
        {
            // Hiển thị thông tin tên sinh viên
            string result = $"Họ và tên: {studentName}\r\n";

            // Hiển thị danh sách điểm kèm tiêu đề môn
            result += "Danh sách điểm:\r\n";
            for (int i = 0; i < scores.Length; i++)
            {
                result += $"Môn {i + 1}: {scores[i]}\r\n";
            }

            // Hiển thị học sinh có điểm cao nhất
            double maxScore = scores[0]; 
            int maxScoreIndex = 1; 
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxScoreIndex = i + 1; 
                }
            }
            result += $"Môn điểm cao nhất: {maxScore}\r\n";


            //Hiển thị  điểm thấp nhất:
            double minScore = scores[0];
            int minScoreIndex = 1;

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minScoreIndex = i + 1;
                }
            }
            result += $"Môn điểm thấp nhất: {minScore}\r\n";
            // Hiển thị điểm trung bình đạt hoặc ko
            int dau = scores.Count(score => score >= 5);
            int rot = scores.Length - dau;
            result += $"Số môn đậu: {dau}\r\n";
            result += $"Số môn rớt: {rot}\r\n";

            double diemTrungBinh = TinhDiemTrungBinh(scores);
            string xepLoai = XepLoai(diemTrungBinh, scores);
            // Hiển thị thông tin trong TextBox
            txtResult.Text = result;

            // Thực hiện các phép tính khác và hiển thị kết quả ở đây
        }
        
        private double TinhDiemTrungBinh(double[] scores)
        {
            if (scores.Length == 0)
            {
                return 0;
            }

            double tongDiem = 0;
            foreach (double diem in scores)
            {
                tongDiem += diem;
            }

            return tongDiem / scores.Length;
        }

        private string XepLoai(double diemTrungBinh, double[] scores)
        {
            if (diemTrungBinh >= 8 && scores.All(score => score >= 6.5))
            {
                return "Giỏi";
            }
            else if (diemTrungBinh >= 6.5 && scores.All(score => score >= 5))
            {
                return "Khá";
            }
            else if (diemTrungBinh >= 5 && scores.All(score => score >= 3.5))
            {
                return "TB";
            }
            else if (diemTrungBinh >= 3.5 && scores.All(score => score >= 2))
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

       
    }
}
