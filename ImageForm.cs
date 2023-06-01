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
using System.IO;
namespace MovieApp
{
    public partial class ImageForm : Form
    {
        string chuoiKetNoi = @"Data Source=KOCHOIGAMENUA\SQLEXPRESS;Initial Catalog=MovieApp;Integrated Security=True";
        public ImageForm()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from ThongTin";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridViewAnh.DataSource = tb;
                dataGridViewAnh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                for(int i = 0; i< dataGridViewAnh.Rows.Count; i++)
                {
                    if(dataGridViewAnh.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridViewAnh.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                    foreach(DataGridViewRow row in dataGridViewAnh.Rows)
                    {
                        row.Height = 80;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        //Ve menu chinh
        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mnForm = new MainForm();
            mnForm.Show();
            this.Hide();
        }
        //Load anh
        private void ImageForm_Load(object sender, EventArgs e)
        {
            load();
        }
        //Chon tep
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp hình ảnh cần tải lên";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.png)|*.gif; *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                txtImageText.Text = openFileDialog.FileName;
            }
        }
        //chuyen dinh dang tu jpg sang byte
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtImageText.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            return picbyte;
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "insert into ThongTin values (@TenPhim,@Anh)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenPhim",txtTenPhim1.Text);
                cmd.Parameters.AddWithValue("@Anh", convertImageToBytes());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm thành công");
                dataGridViewAnh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                txtImageText.Text = "";
                txtTenPhim1.Text = "";
                
                pictureBox1.Image = null;
                load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Click vao thong tin anh thi se hien thong tin len textbox
        private void dataGridViewAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewAnh.Rows[e.RowIndex];
                txtTenPhim1.Text = row.Cells[0].Value.ToString();             
                dataGridViewAnh.CurrentRow.Selected = true;
                int id = Convert.ToInt32(dataGridViewAnh.Rows[e.RowIndex].Cells["TenPhim"].FormattedValue);
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ImageFile from ThongTin where TenPhim ='"+id+"'", conn);
                string img = cmd.ExecuteScalar().ToString();
                pictureBox1.Image = Image.FromFile(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xoá phim này không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "Delete from ThongTin where TenPhim= N'" + txtTenPhim1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá phim thành công");             
                load();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Phim chưa được xoá");
            }
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {          
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Nhập tên phim cần tìm");
            }
            else
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "Select * from ThongTin where TenPhim=@TenPhim";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("TimTenPhim", txtTimPhim.Text);
                cmd.Parameters.AddWithValue("TenPhim", txtTimKiem.Text);
                //cmd.Parameters.AddWithValue("MaPhim", txtMaPhim1.Text);
                //cmd.Parameters.AddWithValue("Anh", pictureBox1.Image);               
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                MessageBox.Show("Tìm kiếm phim thành công");
                dt.Load(rd);
                dataGridViewAnh.DataSource = dt;
                //txtTimPhim.Clear();
                //load();
            }
        }
    }
}
