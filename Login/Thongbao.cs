using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Login.LOGIN;

namespace Login
{
    public partial class Thongbao : Form
    {
        private Controller obj;

        public Thongbao(Controller obj)
        {
            InitializeComponent();

            Thongbao thongbao = this;
            thongbao.obj = obj;

            if (obj != null)
            {
                lbUser.Text = obj.User;
                lbPass.Text = obj.Pass;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
