using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuttyManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pKey.Text) || string.IsNullOrEmpty(tb_repKey.Text))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }
            if(tb_repKey.Text != tb_pKey.Text)
            {
                MessageBox.Show("Thông tin nhập không giống nhau");
            }

            this.Hide();
            MainApp ms = new MainApp();
            ms.InputKey(tb_pKey.Text);
            ms.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
