using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class EquipmentForm : Form
    {
        string chuoiKetNoi = @"Data Source=KOCHOIGAMENUA\SQLEXPRESS;Initial Catalog=MovieApp;Integrated Security=True";
        public EquipmentForm()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            try
            {
                conn.Open();
                string sql = "select * from ThietBi";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridViewThietBi.DataSource = tb;
                dataGridViewThietBi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                for (int i = 0; i < dataGridViewThietBi.Rows.Count; i++)
                {
                    if (dataGridViewThietBi.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridViewThietBi.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                        break;
                    }
                    foreach (DataGridViewRow row in dataGridViewThietBi.Rows)
                    {
                        row.Height = 120;
                       
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.png)|*.gif; *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                txtImageText.Text = openFileDialog.FileName;
            }
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            //fs = new FileStream(txtImageText.Text, FileMode.Open, FileAccess.Read);
            fs = new FileStream(txtImageText.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            return picbyte;
        }
        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "insert into ThietBi values (@TenThietBi,@XuatXu,@SoLuong,@Anh)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenThietBi", txtTenThietBi.Text);
                cmd.Parameters.AddWithValue("@XuatXu", cbXuatXu.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@Anh", convertImageToBytes());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm thành công");
                dataGridViewThietBi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                txtImageText.Text = "";
                txtTenThietBi.Text = "";
                cbXuatXu.Text = "";
                txtSoLuong.ResetText();
                pictureBox1.Image = null;
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xoá thiết bị này không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "Delete from ThietBi where TenThietBi= N'"+txtTenThietBi.Text+"'";
               
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thiết bị thành công");
                load();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Thiết bị chưa được xoá");
            }
        }

        private void dataGridViewThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewThietBi.Rows[e.RowIndex];
                txtTenThietBi.Text = row.Cells[0].Value.ToString();
                cbXuatXu.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                dataGridViewThietBi.CurrentRow.Selected = true;
                int id = Convert.ToInt32(dataGridViewThietBi.Rows[e.RowIndex].Cells["TenThietBi"].FormattedValue);
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select ImageFile from ThietBi where TenThietBi ='" + id + "'", conn);
                string img = cmd.ExecuteScalar().ToString();
                pictureBox1.Image = Image.FromFile(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
