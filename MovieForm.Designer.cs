namespace MovieApp
{
    partial class MovieForm
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
            this.dataGridViewPhim = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtDoDai = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimPhim = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuaPhim = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLamMoiPhim = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTimPhim = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giao diện quản lí phim";
            // 
            // dataGridViewPhim
            // 
            this.dataGridViewPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhim.Location = new System.Drawing.Point(549, 133);
            this.dataGridViewPhim.Name = "dataGridViewPhim";
            this.dataGridViewPhim.RowHeadersWidth = 51;
            this.dataGridViewPhim.RowTemplate.Height = 24;
            this.dataGridViewPhim.ShowCellErrors = false;
            this.dataGridViewPhim.ShowRowErrors = false;
            this.dataGridViewPhim.Size = new System.Drawing.Size(952, 592);
            this.dataGridViewPhim.TabIndex = 3;
            this.dataGridViewPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhim_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Độ dài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thời gian chiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Xuất xứ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ghi chú";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(134, 142);
            this.txtTenPhim.Multiline = true;
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(390, 28);
            this.txtTenPhim.TabIndex = 15;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(134, 197);
            this.txtMaPhim.Multiline = true;
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(390, 29);
            this.txtMaPhim.TabIndex = 16;
            // 
            // txtDoDai
            // 
            this.txtDoDai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDoDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoDai.Location = new System.Drawing.Point(134, 255);
            this.txtDoDai.Multiline = true;
            this.txtDoDai.Name = "txtDoDai";
            this.txtDoDai.Size = new System.Drawing.Size(390, 29);
            this.txtDoDai.TabIndex = 17;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(196, 321);
            this.txtThoiGian.Multiline = true;
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(328, 28);
            this.txtThoiGian.TabIndex = 18;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatXu.Location = new System.Drawing.Point(134, 379);
            this.txtXuatXu.Multiline = true;
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(390, 29);
            this.txtXuatXu.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(134, 434);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(390, 29);
            this.txtGhiChu.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nhập tên phim cần tìm";
            // 
            // txtTimPhim
            // 
            this.txtTimPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimPhim.Location = new System.Drawing.Point(818, 96);
            this.txtTimPhim.Multiline = true;
            this.txtTimPhim.Name = "txtTimPhim";
            this.txtTimPhim.Size = new System.Drawing.Size(392, 31);
            this.txtTimPhim.TabIndex = 22;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhim.Image = global::MovieApp.Properties.Resources.plus;
            this.btnThemPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhim.Location = new System.Drawing.Point(10, 522);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(154, 56);
            this.btnThemPhim.TabIndex = 10;
            this.btnThemPhim.Text = "    Thêm";
            this.toolTip1.SetToolTip(this.btnThemPhim, "Thêm mới phim vào database");
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhim.Image = global::MovieApp.Properties.Resources.remove;
            this.btnXoaPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhim.Location = new System.Drawing.Point(185, 523);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(159, 55);
            this.btnXoaPhim.TabIndex = 12;
            this.btnXoaPhim.Text = "   Xoá";
            this.toolTip2.SetToolTip(this.btnXoaPhim, "Xoá phim khỏi database");
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            this.btnXoaPhim.Click += new System.EventHandler(this.btnXoaPhim_Click);
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhim.Image = global::MovieApp.Properties.Resources.tool;
            this.btnSuaPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhim.Location = new System.Drawing.Point(371, 523);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(153, 55);
            this.btnSuaPhim.TabIndex = 11;
            this.btnSuaPhim.Text = "Sửa";
            this.toolTip3.SetToolTip(this.btnSuaPhim, "Sửa thông tin của phim được chọn");
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // toolTip4
            // 
            this.toolTip4.IsBalloon = true;
            // 
            // btnLamMoiPhim
            // 
            this.btnLamMoiPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiPhim.Image = global::MovieApp.Properties.Resources.eraser;
            this.btnLamMoiPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiPhim.Location = new System.Drawing.Point(10, 623);
            this.btnLamMoiPhim.Name = "btnLamMoiPhim";
            this.btnLamMoiPhim.Size = new System.Drawing.Size(156, 58);
            this.btnLamMoiPhim.TabIndex = 13;
            this.btnLamMoiPhim.Text = "   Làm mới";
            this.toolTip4.SetToolTip(this.btnLamMoiPhim, "Làm mới thông tin phim đã nhập");
            this.btnLamMoiPhim.UseVisualStyleBackColor = true;
            this.btnLamMoiPhim.Click += new System.EventHandler(this.btnLamMoiPhim_Click);
            // 
            // toolTip5
            // 
            this.toolTip5.IsBalloon = true;
            this.toolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Image = global::MovieApp.Properties.Resources.arrow;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(371, 624);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(153, 56);
            this.btnQuayLai.TabIndex = 14;
            this.btnQuayLai.Text = "    Quay lại";
            this.toolTip5.SetToolTip(this.btnQuayLai, "Quay lại màn hình chính");
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // toolTip6
            // 
            this.toolTip6.IsBalloon = true;
            // 
            // btnTimPhim
            // 
            this.btnTimPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhim.Image = global::MovieApp.Properties.Resources.search;
            this.btnTimPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimPhim.Location = new System.Drawing.Point(1243, 96);
            this.btnTimPhim.Name = "btnTimPhim";
            this.btnTimPhim.Size = new System.Drawing.Size(174, 34);
            this.btnTimPhim.TabIndex = 23;
            this.btnTimPhim.Text = "Tìm kiếm";
            this.toolTip6.SetToolTip(this.btnTimPhim, "Tìm kiếm phim dựa trên tên phim");
            this.btnTimPhim.UseVisualStyleBackColor = true;
            this.btnTimPhim.Click += new System.EventHandler(this.btnTimPhim_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Image = global::MovieApp.Properties.Resources.undo;
            this.btnTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiLai.Location = new System.Drawing.Point(185, 623);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(159, 58);
            this.btnTaiLai.TabIndex = 24;
            this.btnTaiLai.Text = " Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Tan;
            this.pictureBox2.Image = global::MovieApp.Properties.Resources.movie;
            this.pictureBox2.Location = new System.Drawing.Point(351, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 78);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1500, 746);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTimPhim);
            this.Controls.Add(this.txtTimPhim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtDoDai);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnLamMoiPhim);
            this.Controls.Add(this.btnXoaPhim);
            this.Controls.Add(this.btnSuaPhim);
            this.Controls.Add(this.btnThemPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPhim);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Button btnSuaPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnLamMoiPhim;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtDoDai;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimPhim;
        private System.Windows.Forms.Button btnTimPhim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Button btnTaiLai;
    }
}