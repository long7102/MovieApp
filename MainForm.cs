
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn quay lại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                LoginForm lgForm = new LoginForm();
                lgForm.Show();
                this.Hide();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketForm tkForm = new TicketForm();
            tkForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieForm mvForm = new MovieForm();
            mvForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuggestForm sForm = new SuggestForm();
            sForm.Show();
            this.Hide();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ImageForm iForm = new ImageForm();
            iForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            EquipmentForm eForm = new EquipmentForm();
            eForm.Show();
            this.Hide();
        }
    }
}
