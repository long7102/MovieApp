using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieApp
{
    public partial class MovieForm : Form
    {
        string chuoiKetNoi = @"Data Source=KOCHOIGAMENUA\SQLEXPRESS;Initial Catalog=MovieApp;Integrated Security=True";
        public MovieForm()
        {
            InitializeComponent();
        }
        //load data len datagridview
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from Phim";
                SqlDataAdapter dt = new SqlDataAdapter(sql,conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridViewPhim.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " +ex.Message);
            }
        }
        //Quay lai man hinh chinh
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            MainForm mnForm = new MainForm();
            mnForm.Show();
            this.Hide();
        }
        //Xoa thong tin text box
        public void refresh()
        {
            txtDoDai.Clear();
            txtGhiChu.Clear();
            txtMaPhim.Clear();
            txtTenPhim.Clear();
            txtThoiGian.Clear();
            txtXuatXu.Clear();
        }
        //Nut lam moi
        private void btnLamMoiPhim_Click(object sender, EventArgs e)
        {
            txtDoDai.Clear();   
            txtGhiChu.Clear();
            txtMaPhim.Clear();
            txtTenPhim.Clear();
            txtThoiGian.Clear();
            txtXuatXu.Clear();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            load();
        }
        public bool kiemTraPhim(string MaPhim)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "select MaPhim from Phim where MaPhim = '"+MaPhim+"'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true) 
            { 
                conn.Close();
                return true; 
            }
            else 
            {
                conn.Close();
                return false;
            }
            
        }
        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try {
                if(txtTenPhim.Text != "" && txtMaPhim.Text != "" && txtDoDai.Text != "" && txtThoiGian.Text != "" ){ 
                    if(kiemTraPhim(txtMaPhim.Text) == true)
                    {
                        MessageBox.Show("Mã phim đã tồn tại");
                    }                  
                    else
                    {
                        conn.Open();
                        string sql = "insert into Phim values('" + txtTenPhim.Text + "' , '" + txtMaPhim.Text + "', '" + txtDoDai.Text + "', '" + txtThoiGian.Text + "', '" + txtXuatXu.Text + "', '" + txtGhiChu.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công");
                            refresh();
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                            conn.Close();
                        }
                    } 
                
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "UPDATE Phim SET TenPhim=@TenPhim,DoDai=@DoDai,ThoiGianChieu=@ThoiGianChieu,XuatXu=@XuatXu,GhiChu=@GhiChu WHERE MaPhim = @MaPhim";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("TenPhim", txtTenPhim.Text);
                cmd.Parameters.AddWithValue("MaPhim", txtMaPhim.Text);
                cmd.Parameters.AddWithValue("DoDai", txtDoDai.Text);
                cmd.Parameters.AddWithValue("ThoiGianChieu", txtThoiGian.Text);
                cmd.Parameters.AddWithValue("XuatXu", txtXuatXu.Text);
                cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin phim thành công");
                refresh();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void dataGridViewPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewPhim.Rows[e.RowIndex];
            txtTenPhim.Text = row.Cells[0].Value.ToString();
            txtMaPhim.Text = row.Cells[1].Value.ToString();
            txtDoDai.Text = row.Cells[2].Value.ToString();
            txtThoiGian.Text = row.Cells[3].Value.ToString();
            txtXuatXu.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xoá phim này không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "Delete from Phim where MaPhim= '"+txtMaPhim.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, conn); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá phim thành công");
                refresh();
                load();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Phim chưa được xoá");
            }
        }

        private void btnTimPhim_Click(object sender, EventArgs e)
        {
            if (txtTimPhim.Text == "")
            {
                MessageBox.Show("Nhập tên phim cần tìm");
            }
            else { 
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "Select * from Phim where TenPhim=@TenPhim";
            SqlCommand cmd = new SqlCommand(sql,conn);
            //cmd.Parameters.AddWithValue("TimTenPhim", txtTimPhim.Text);
            cmd.Parameters.AddWithValue("TenPhim", txtTimPhim.Text);
            cmd.Parameters.AddWithValue("MaPhim", txtMaPhim.Text);
            cmd.Parameters.AddWithValue("DoDai", txtDoDai.Text);
            cmd.Parameters.AddWithValue("ThoiGianChieu", txtThoiGian.Text);
            cmd.Parameters.AddWithValue("XuatXu", txtXuatXu.Text);
            cmd.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);            
            cmd.ExecuteNonQuery();         
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
                MessageBox.Show("Tìm kiếm phim thành công");
                dt.Load(rd);
            dataGridViewPhim.DataSource = dt;
                //txtTimPhim.Clear();
                //load();
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
