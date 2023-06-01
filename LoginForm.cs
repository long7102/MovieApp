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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=KOCHOIGAMENUA\SQLEXPRESS;Initial Catalog=MovieApp;Integrated Security=True");
            try {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtPass.Text;
                string sql = "select * from DangNhap where TaiKhoan ='" + tk + "' and MatKhau='" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công, xin chào " + txtTaiKhoan.Text);
                    MainForm mForm = new MainForm();
                    mForm.Show();
                    this.Hide();
                }
                else if(txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Tài khoản không được để trống" );
                }
                else if (txtPass.Text == "")
                {
                    MessageBox.Show("Tài khoản không được để trống");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, xin kiểm tra lại tên đăng nhập và mật khẩu");
                    txtTaiKhoan.Clear();
                    txtPass.Clear();
                } 
                    
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }
    }
}
