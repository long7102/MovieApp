namespace MovieApp
{
    partial class TicketForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenVe = new System.Windows.Forms.TextBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.txtTenPhim1 = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtChuThich = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThemVe = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnXoaVe = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuaVe = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLamMoiVe = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTaiLaiPhim = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimVe = new System.Windows.Forms.TextBox();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTimVe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDichVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giao diện quản lý vé phim";
            // 
            // dataGridViewVe
            // 
            this.dataGridViewVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVe.Location = new System.Drawing.Point(593, 130);
            this.dataGridViewVe.Name = "dataGridViewVe";
            this.dataGridViewVe.RowHeadersWidth = 51;
            this.dataGridViewVe.RowTemplate.Height = 24;
            this.dataGridViewVe.ShowCellErrors = false;
            this.dataGridViewVe.ShowRowErrors = false;
            this.dataGridViewVe.Size = new System.Drawing.Size(1000, 607);
            this.dataGridViewVe.TabIndex = 3;
            this.dataGridViewVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVe_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã vé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chú thích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 437);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dịch vụ";
            // 
            // txtTenVe
            // 
            this.txtTenVe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVe.Location = new System.Drawing.Point(141, 135);
            this.txtTenVe.Multiline = true;
            this.txtTenVe.Name = "txtTenVe";
            this.txtTenVe.Size = new System.Drawing.Size(417, 29);
            this.txtTenVe.TabIndex = 11;
            // 
            // txtMaVe
            // 
            this.txtMaVe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVe.Location = new System.Drawing.Point(141, 193);
            this.txtMaVe.Multiline = true;
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(417, 30);
            this.txtMaVe.TabIndex = 12;
            // 
            // txtTenPhim1
            // 
            this.txtTenPhim1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenPhim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim1.Location = new System.Drawing.Point(141, 257);
            this.txtTenPhim1.Multiline = true;
            this.txtTenPhim1.Name = "txtTenPhim1";
            this.txtTenPhim1.Size = new System.Drawing.Size(417, 26);
            this.txtTenPhim1.TabIndex = 13;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(141, 314);
            this.txtGiaTien.Multiline = true;
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(417, 29);
            this.txtGiaTien.TabIndex = 14;
            // 
            // txtChuThich
            // 
            this.txtChuThich.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuThich.Location = new System.Drawing.Point(141, 376);
            this.txtChuThich.Multiline = true;
            this.txtChuThich.Name = "txtChuThich";
            this.txtChuThich.Size = new System.Drawing.Size(417, 29);
            this.txtChuThich.TabIndex = 15;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(141, 437);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(417, 29);
            this.txtSoLuong.TabIndex = 16;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnThemVe
            // 
            this.btnThemVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVe.Image = global::MovieApp.Properties.Resources.plus;
            this.btnThemVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVe.Location = new System.Drawing.Point(23, 568);
            this.btnThemVe.Name = "btnThemVe";
            this.btnThemVe.Size = new System.Drawing.Size(163, 52);
            this.btnThemVe.TabIndex = 18;
            this.btnThemVe.Text = "   Thêm";
            this.toolTip1.SetToolTip(this.btnThemVe, "Thêm mới vé vào database");
            this.btnThemVe.UseVisualStyleBackColor = true;
            this.btnThemVe.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // btnXoaVe
            // 
            this.btnXoaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVe.Image = global::MovieApp.Properties.Resources.remove;
            this.btnXoaVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaVe.Location = new System.Drawing.Point(218, 568);
            this.btnXoaVe.Name = "btnXoaVe";
            this.btnXoaVe.Size = new System.Drawing.Size(160, 51);
            this.btnXoaVe.TabIndex = 19;
            this.btnXoaVe.Text = "         Xoá";
            this.btnXoaVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip2.SetToolTip(this.btnXoaVe, "Xoá vé được chọn ra khỏi database");
            this.btnXoaVe.UseVisualStyleBackColor = true;
            this.btnXoaVe.Click += new System.EventHandler(this.btnXoaVe_Click);
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            // 
            // btnSuaVe
            // 
            this.btnSuaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaVe.Image = global::MovieApp.Properties.Resources.tool;
            this.btnSuaVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaVe.Location = new System.Drawing.Point(399, 568);
            this.btnSuaVe.Name = "btnSuaVe";
            this.btnSuaVe.Size = new System.Drawing.Size(159, 51);
            this.btnSuaVe.TabIndex = 20;
            this.btnSuaVe.Text = "         Sửa";
            this.btnSuaVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip3.SetToolTip(this.btnSuaVe, "Sửa thông tin vé được chọn");
            this.btnSuaVe.UseVisualStyleBackColor = true;
            this.btnSuaVe.Click += new System.EventHandler(this.btnSuaVe_Click);
            // 
            // toolTip4
            // 
            this.toolTip4.IsBalloon = true;
            // 
            // btnLamMoiVe
            // 
            this.btnLamMoiVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiVe.Image = global::MovieApp.Properties.Resources.eraser;
            this.btnLamMoiVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiVe.Location = new System.Drawing.Point(26, 638);
            this.btnLamMoiVe.Name = "btnLamMoiVe";
            this.btnLamMoiVe.Size = new System.Drawing.Size(160, 52);
            this.btnLamMoiVe.TabIndex = 21;
            this.btnLamMoiVe.Text = "   Làm mới";
            this.toolTip4.SetToolTip(this.btnLamMoiVe, "Làm mới thông tin đã nhập");
            this.btnLamMoiVe.UseVisualStyleBackColor = true;
            this.btnLamMoiVe.Click += new System.EventHandler(this.btnLamMoiVe_Click);
            // 
            // toolTip5
            // 
            this.toolTip5.IsBalloon = true;
            // 
            // btnTaiLaiPhim
            // 
            this.btnTaiLaiPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLaiPhim.Image = global::MovieApp.Properties.Resources.undo;
            this.btnTaiLaiPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiLaiPhim.Location = new System.Drawing.Point(218, 638);
            this.btnTaiLaiPhim.Name = "btnTaiLaiPhim";
            this.btnTaiLaiPhim.Size = new System.Drawing.Size(160, 52);
            this.btnTaiLaiPhim.TabIndex = 26;
            this.btnTaiLaiPhim.Text = " Tải lại";
            this.toolTip5.SetToolTip(this.btnTaiLaiPhim, "Tải lại thông tin phim");
            this.btnTaiLaiPhim.UseVisualStyleBackColor = true;
            this.btnTaiLaiPhim.Click += new System.EventHandler(this.btnTaiLaiPhim_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Image = global::MovieApp.Properties.Resources.arrow;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(398, 638);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(160, 51);
            this.btnQuayLai.TabIndex = 22;
            this.btnQuayLai.Text = "   Quay lại";
            this.toolTip5.SetToolTip(this.btnQuayLai, "Quay lại màn hình chính");
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(588, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nhập mã vé cần tìm";
            // 
            // txtTimVe
            // 
            this.txtTimVe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimVe.Location = new System.Drawing.Point(817, 92);
            this.txtTimVe.Multiline = true;
            this.txtTimVe.Name = "txtTimVe";
            this.txtTimVe.Size = new System.Drawing.Size(429, 32);
            this.txtTimVe.TabIndex = 24;
            // 
            // toolTip6
            // 
            this.toolTip6.IsBalloon = true;
            // 
            // btnTimVe
            // 
            this.btnTimVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimVe.Image = global::MovieApp.Properties.Resources.search;
            this.btnTimVe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimVe.Location = new System.Drawing.Point(1276, 89);
            this.btnTimVe.Name = "btnTimVe";
            this.btnTimVe.Size = new System.Drawing.Size(175, 35);
            this.btnTimVe.TabIndex = 25;
            this.btnTimVe.Text = "Tìm kiếm";
            this.toolTip6.SetToolTip(this.btnTimVe, "Tìm kiếm thông tin phim đã nhập");
            this.btnTimVe.UseVisualStyleBackColor = true;
            this.btnTimVe.Click += new System.EventHandler(this.btnTimVe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox2.Image = global::MovieApp.Properties.Resources.ticket3;
            this.pictureBox2.Location = new System.Drawing.Point(332, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtDichVu
            // 
            this.txtDichVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDichVu.DropDownWidth = 272;
            this.txtDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDichVu.FormattingEnabled = true;
            this.txtDichVu.Items.AddRange(new object[] {
            "Bỏng + Nước",
            "Chụp hình",
            "Quà tặng kèm",
            "Khuyến mãi",
            "Bốc thăm trúng thưởng",
            "Rút số",
            "Voucher",
            "Giảm giá",
            "Không"});
            this.txtDichVu.Location = new System.Drawing.Point(141, 499);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(272, 33);
            this.txtDichVu.TabIndex = 27;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1585, 739);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.btnTaiLaiPhim);
            this.Controls.Add(this.btnTimVe);
            this.Controls.Add(this.txtTimVe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnLamMoiVe);
            this.Controls.Add(this.btnSuaVe);
            this.Controls.Add(this.btnXoaVe);
            this.Controls.Add(this.btnThemVe);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtChuThich);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenPhim1);
            this.Controls.Add(this.txtMaVe);
            this.Controls.Add(this.txtTenVe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewVe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenVe;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtTenPhim1;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtChuThich;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThemVe;
        private System.Windows.Forms.Button btnXoaVe;
        private System.Windows.Forms.Button btnSuaVe;
        private System.Windows.Forms.Button btnLamMoiVe;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimVe;
        private System.Windows.Forms.Button btnTimVe;
        private System.Windows.Forms.Button btnTaiLaiPhim;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ComboBox txtDichVu;
    }
}