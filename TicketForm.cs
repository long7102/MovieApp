using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class TicketForm : Form
    {
        string chuoiKetNoi = @"Data Source=KOCHOIGAMENUA\SQLEXPRESS;Initial Catalog=MovieApp;Integrated Security=True";
        public TicketForm()
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
                string sql = "select * from Ve";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridViewVe.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            MainForm mnForm = new MainForm();
            mnForm.Show();
            this.Hide();
        }

        private void btnLamMoiVe_Click(object sender, EventArgs e)
        {
            txtTenVe.Clear();
            txtChuThich.Clear();
            txtDichVu.ResetText();
            txtGiaTien.Clear();
            txtMaVe.Clear();
            txtSoLuong.Clear();
            txtDichVu.ResetText();
            txtTenPhim1.Clear();
        }
        public void refresh()
        {
            txtTenVe.Clear();
            txtChuThich.Clear();
            txtDichVu.ResetText();
            txtGiaTien.Clear();
            txtMaVe.Clear();
            txtSoLuong.Clear();
            txtDichVu.ResetText();
            txtTenPhim1.Clear();
        }
        private void TicketForm_Load(object sender, EventArgs e)
        {
            load();
        }
        public bool kiemTraVe(string MaVe)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "select MaVe from Ve where MaVe = '"+MaVe+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
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
        private void btnThemVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                if (txtTenVe.Text != "" && txtMaVe.Text != "" && txtTenPhim1.Text != "" && txtGiaTien.Text != "" &&txtChuThich.Text !="" && txtDichVu.Text !="")
                {
                    if (kiemTraVe(txtMaVe.Text) == true)
                    {
                        MessageBox.Show("Mã vé đã tồn tại");
                    }
                    else
                    {
                        conn.Open();
                        string sql = "insert into Ve values('" + txtTenVe.Text + "' , '" + txtMaVe.Text + "', '" + txtTenPhim1.Text + "', '" + txtGiaTien.Text + "', '" + txtChuThich.Text + "', '" + txtSoLuong.Text + "', '" + txtDichVu.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        int kq = (int)cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm mới vé thành công");
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

        private void dataGridViewVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewVe.Rows[e.RowIndex];
                txtTenVe.Text = row.Cells[0].Value.ToString();
                txtMaVe.Text = row.Cells[1].Value.ToString();
                txtTenPhim1.Text = row.Cells[2].Value.ToString();
                txtGiaTien.Text = row.Cells[3].Value.ToString();
                txtChuThich.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                txtDichVu.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xoá vé này không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "Delete from Ve where MaVe='" + txtMaVe.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá vé thành công");
                refresh();
                load();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vé chưa được xoá");
            }
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "UPDATE Ve SET TenVe=@TenVe,MaVe=@MaVe,TenPhim=@TenPhim,GiaTien=@GiaTien,ChuThich=@ChuThich,SoLuong=@SoLuong,DichVu=@DichVu WHERE MaVe = @MaVe";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Tenve", txtTenVe.Text);
                cmd.Parameters.AddWithValue("MaVe", txtMaVe.Text);          
                cmd.Parameters.AddWithValue("TenPhim", txtTenPhim1.Text);
                cmd.Parameters.AddWithValue("GiaTien", txtGiaTien.Text);
                cmd.Parameters.AddWithValue("ChuThich", txtChuThich.Text);
                cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("DichVu", txtDichVu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin vé thành công");
                refresh();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnTimVe_Click(object sender, EventArgs e)
        {
            if(txtTimVe.Text == "")
            {
                MessageBox.Show("Nhập mã vé cần tìm ");
            }
            else
            {      
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            string sql = "Select * from Ve where TenPhim=@TenPhim";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("TimV", txtTimPhim.Text);
            cmd.Parameters.AddWithValue("TenVe", txtTenVe.Text);
            cmd.Parameters.AddWithValue("TenPhim", txtTimVe.Text);
            //cmd.Parameters.AddWithValue("TenPhim", txtTenPhim1.Text);
            cmd.Parameters.AddWithValue("GiaTien", txtGiaTien.Text);
            cmd.Parameters.AddWithValue("ChuThich", txtChuThich.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("DichVu", txtDichVu.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            MessageBox.Show("Tìm kiếm vé thành công");
            dt.Load(rd);
            dataGridViewVe.DataSource = dt;

                //txtTimVe.Clear();
                //load();
            }
        }

        private void btnTaiLaiPhim_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
