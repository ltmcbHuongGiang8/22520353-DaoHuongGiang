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
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            UpdateFavoriteFoodsTextBox();
        }
        private List<string> favoriteFoods = new List<string>
        {
            "Cơm rang",
            "Phở",
            "Bún chả",
            "Bánh mì",
            "Gà nướng"
        };
        private List<string> FVRbd = new List<string>
        {
            "Cơm rang",
            "Phở",
            "Bún chả",
            "Bánh mì",
            "Gà nướng"
        };

        private void button2_Click(object sender, EventArgs e)
        {
            if (favoriteFoods.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, favoriteFoods.Count);
                textBox3.Text = favoriteFoods[index];
            }
            else
            {
                textBox3.Text = "Không có món ăn nào";
            }
        }

        private void UpdateFavoriteFoodsTextBox()
        {
            textBox2.Text = string.Join(Environment.NewLine, favoriteFoods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFood = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(newFood))
            {
                favoriteFoods.Add(newFood);
                UpdateFavoriteFoodsTextBox();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = string.Join(Environment.NewLine, FVRbd);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
