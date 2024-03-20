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
    public partial class Form2 : Form
    {
        List<string> list;
        public Form2()
        {
            InitializeComponent();
            List<Phim> list = new List<Phim>();

            // Thêm dữ liệu cho mỗi bộ phim vào danh sách
            list.Add(new Phim()
            {
                Name = "Đào, phở và piano",
                Price = "45.000đ",
                Room = new List<int>() { 1, 2, 3 }
            });

            list.Add(new Phim()
            {
                Name = "Mai",
                Price = "100.000đ",
                Room = new List<int>() { 2, 3 }
            });

            list.Add(new Phim()
            {
                Name = "Gặp lại chị bầu",
                Price = "70.000đ",
                Room = new List<int>() { 1 }
            });

            list.Add(new Phim()
            {
                Name = "Tarot",
                Price = "90.000đ",
                Room = new List<int>() { 3 }
            });
            phim.DataSource = list;
            phim.DisplayMember = "Name";

            AddBinding();
            List<string> danhSachChoNgoi = new List<string>();

            // Thêm các chỗ ngồi vào danh sách
            danhSachChoNgoi.AddRange(new string[] { "Vé vớt A1", "Vé vớt A5", "Vé vớt C1", "Vé vớt C5",
                                        "Vé thường A2", "Vé thường A3", "Vé thường A4", "Vé thường C2", "Vé thường C3", "Vé thường C4",
                                        "Vé VIP B2", "Vé VIP B3", "Vé VIP B4" });

            // Thêm danh sách chỗ ngồi vào CheckedListBox
            soGheCheckedListBox.Items.AddRange(danhSachChoNgoi.ToArray());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        void AddBinding()
        {
           
        }
        public class Phim
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public List<int> Room { get; set; }
        }

        private void phim_SelectedValueChanged(object sender, EventArgs e) 

        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                // Lấy thông tin của bộ phim được chọn từ ComboBox
                Phim selectedPhim = cb.SelectedValue as Phim;

                // Hiển thị giá vé trong ComboBox giaComboBox
                giave.Text = selectedPhim.Price;

                // Hiển thị danh sách các phòng chiếu trong ComboBox rapChieuComboBox
                rapchieu.Items.Clear();
                foreach (int room in selectedPhim.Room)
                {
                    rapchieu.Items.Add(room);
                }
               
            }
        }
        private void loaiVeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng từ TextBox
            string hoTen = txtHoTen.Text;

            // Lấy thông tin phim và phòng chiếu từ ComboBox
            Phim selectedPhim = phim.SelectedItem as Phim;
            int phongChieu = (int)rapchieu.SelectedItem;

            // Xác định giá vé dựa trên loại phim
            decimal giaVe = 0;
            switch (selectedPhim.Name)
            {
                case "Đào, phở và piano":
                    giaVe = 45000; // Giá vé chuẩn
                    break;
                case "Mai":
                    giaVe = 100000; // Giá vé chuẩn
                    break;
                case "Gặp lại chị bầu":
                    giaVe = 70000; // Giá vé chuẩn
                    break;
                case "Tarot":
                    giaVe = 90000; // Giá vé chuẩn
                    break;
                default:
                    break;
            }

            // Tính tổng số tiền cần thanh toán dựa trên số lượng vé đã chọn
            decimal tongTien = 0;
            foreach (int index in soGheCheckedListBox.CheckedIndices)
            {
                // Xác định giá vé dựa trên chỉ số của mục trong CheckedListBox
                decimal giaVeMoi = 0;
                switch (index)
                {
                    case 0: // Vé vớt A1
                    case 1: // Vé vớt A5
                    case 2: // Vé vớt C1
                    case 3: // Vé vớt C5
                        giaVeMoi = giaVe * 0.25m;
                        break;
                    case 4: // Vé thường A2
                    case 5: // Vé thường A3
                    case 6: // Vé thường A4
                    case 7: // Vé thường C2
                    case 8: // Vé thường C3
                    case 9: // Vé thường C4
                        giaVeMoi = giaVe;
                        break;
                    case 10: // Vé VIP B2
                    case 11: // Vé VIP B3
                    case 12: // Vé VIP B4
                        giaVeMoi = giaVe * 2;
                        break;
                    default:
                        break;
                }

                // Cộng vào tổng số tiền cần thanh toán
                tongTien += giaVeMoi;
            }

            string veDaChon = "";
            foreach (var item in soGheCheckedListBox.CheckedItems)
            {
                veDaChon += item.ToString() + ", ";
            }

            // Loại bỏ dấu phẩy cuối cùng nếu có
            if (veDaChon.Length > 0)
            {
                veDaChon = veDaChon.Substring(0, veDaChon.Length - 2);
            }

            txtThongTinKhachHang.Text = $"Họ và tên: {hoTen}\r\n" +
                                        $"Vé đã chọn: {veDaChon}\r\n" +
                                        $"Tên phim: {selectedPhim.Name}\r\n" +
                                        $"Phòng chiếu: {phongChieu}\r\n" +
                                        $"Số tiền cần thanh toán: {tongTien.ToString("N0")}đ";
        }
    }
}
