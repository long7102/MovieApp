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
    public partial class SuggestForm : Form
    {
        public SuggestForm()
        {
            InitializeComponent();
        }
        //Quay lai trang web truoc do
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        //Di toi trang web tiep theo
        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtGoiY.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mnForm = new MainForm();
            mnForm.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //this.webBrowser1.Navigate(txtGoiY.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://movielens.org/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://autum.com/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bestsimilar.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://letterboxd.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.galaxycine.vn/phim-dang-chieu");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://yeutre.vn/bai-viet/top-100-phim-hay-nhat-moi-thoi-dai-duoc-nguoi-xem-danh-gia-cao.26904/");
        }
    }
}
