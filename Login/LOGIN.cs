using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        public class Controller
        {
            public string User { set; get; }
            public string Pass { set; get; }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // tên đăng nhập
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            // mật khẩu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // thực hiện lệnh tra cứu coi có đúng không.
            string Username, Password;
            Username = txtUser.Text;
            Password = txtPass.Text;

            int Countnum = 0; // đếm số lượng số trong password
            int Countup = 0; // đếm số lượng chữ viết hoa trong password
            int Countlow = 0; // đếm số lượng chữ viết thường trong password
            int Countsp = 0; // đếm số lượng ký tự đặc biệt trong password

            for (int i = 0; i < Password.Length; i++)
            {
                if (Password[i] >= '0' && Password[i] <= '9') Countnum++;
                if (Password[i] >= 'a' && Password[i] <= 'z') Countlow++;
                if (Password[i] >= 'A' && Password[i] <= 'Z') Countup++;
                if (Password[i] >= '!' && Password[i] <= '/' ||
                    Password[i] >= ':' && Password[i] <= '@' ||
                    Password[i] >= '[' && Password[i] <= '`' ||
                    Password[i] >= '{' && Password[i] <= '~') Countsp++;
            }

            if (Username == "" && Password == "")
            {
                MessageBox.Show("User và pass không được trống.");
            }
            else if (Username == "")
            {
                MessageBox.Show("User không được trống");
            }
            else if (Password == "")
            {
                MessageBox.Show("Pass không được trống");
            }
            else if (Username.Length <= 8)
            {
                MessageBox.Show("Tên đăng nhập phải nhiều hơn 8 ký tự!!!");
            }
            else if (Countnum == 0)
            {
                MessageBox.Show("Mật khẩu thiếu số!");
            }
            else if (Countlow == 0)
            {
                MessageBox.Show("Mật khẩu thiếu ký tự thường!");
            }
            else if (Countup == 0)
            {
                MessageBox.Show("Mật khẩu thiếu ký tự HOA!");
            }
            else if (Countsp == 0)
            {
                MessageBox.Show("Mật khẩu thiếu ký tự đặc biệt!");
            }
            else
            {
                /*
                if (Username == "admin" && Password == "12345")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                */
                if (txtUser.Text == "caovietthang" && txtPass.Text == "Abcd!1234")
                {
                    this.Hide();
                    Controller obj = new Controller();
                    obj.User = "caovietthang";
                    obj.Pass = "Abcd!1234";

                    Thongbao f = new Thongbao(obj);
                    f.Show();
                }

                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, xin vui lòng nhập lại");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // thực hiện lệnh thoát ra
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
