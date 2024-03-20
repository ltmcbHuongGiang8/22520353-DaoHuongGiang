namespace _22520353
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phim = new System.Windows.Forms.ComboBox();
            this.rapchieu = new System.Windows.Forms.ComboBox();
            this.soGheCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.giave = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtThongTinKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phim
            // 
            this.phim.FormattingEnabled = true;
            this.phim.Location = new System.Drawing.Point(12, 97);
            this.phim.Name = "phim";
            this.phim.Size = new System.Drawing.Size(121, 24);
            this.phim.TabIndex = 0;
            this.phim.SelectedValueChanged += new System.EventHandler(this.phim_SelectedValueChanged);
            // 
            // rapchieu
            // 
            this.rapchieu.FormattingEnabled = true;
            this.rapchieu.Location = new System.Drawing.Point(315, 97);
            this.rapchieu.Name = "rapchieu";
            this.rapchieu.Size = new System.Drawing.Size(121, 24);
            this.rapchieu.TabIndex = 1;
            // 
            // soGheCheckedListBox
            // 
            this.soGheCheckedListBox.FormattingEnabled = true;
            this.soGheCheckedListBox.Location = new System.Drawing.Point(532, 78);
            this.soGheCheckedListBox.Name = "soGheCheckedListBox";
            this.soGheCheckedListBox.Size = new System.Drawing.Size(234, 327);
            this.soGheCheckedListBox.TabIndex = 3;
            // 
            // giave
            // 
            this.giave.FormattingEnabled = true;
            this.giave.Location = new System.Drawing.Point(161, 97);
            this.giave.Name = "giave";
            this.giave.Size = new System.Drawing.Size(121, 24);
            this.giave.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Tên phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(321, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Rạp phim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(167, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá vé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ và tên Khách Hàng";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(158, 148);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(168, 40);
            this.txtHoTen.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(15, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xuất Thông Tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtThongTinKhachHang
            // 
            this.txtThongTinKhachHang.Location = new System.Drawing.Point(135, 214);
            this.txtThongTinKhachHang.Multiline = true;
            this.txtThongTinKhachHang.Name = "txtThongTinKhachHang";
            this.txtThongTinKhachHang.Size = new System.Drawing.Size(333, 214);
            this.txtThongTinKhachHang.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông Tin Mua Vé";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThongTinKhachHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giave);
            this.Controls.Add(this.soGheCheckedListBox);
            this.Controls.Add(this.rapchieu);
            this.Controls.Add(this.phim);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox phim;
        private System.Windows.Forms.ComboBox rapchieu;
        private System.Windows.Forms.CheckedListBox soGheCheckedListBox;
        private System.Windows.Forms.ComboBox giave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtThongTinKhachHang;
        private System.Windows.Forms.Label label5;
    }
}