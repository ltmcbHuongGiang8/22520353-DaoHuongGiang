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
    public partial class Menu : Form
    {
        List<Form> OpenedForm = new List<Form>();
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 form = new Lab01_Bai01();
            form.Show();
            OpenedForm.Add(form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 form = new Lab01_Bai02();
            form.Show();
            OpenedForm.Add(form);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form form in OpenedForm)
            {
                    form.Close();
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 form = new Lab01_Bai03();
            form.Show();
            OpenedForm.Add(form);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 form = new Lab01_Bai05();
            form.Show();
            OpenedForm.Add(form);
        }
        

        private void button6_Click_1(object sender, EventArgs e)
        {
            Lab01_Bai06 form = new Lab01_Bai06();
            form.Show();
            OpenedForm.Add(form);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 form = new Lab01_Bai07();
            form.Show();
            OpenedForm.Add(form);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 form = new Lab01_Bai08();
            form.Show();
            OpenedForm.Add(form);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            OpenedForm.Add(form);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Lab01_Bai31 form = new Lab01_Bai31();
            form.Show();
            OpenedForm.Add(form);
        }
    }
}
