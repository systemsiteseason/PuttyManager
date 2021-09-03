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
    public partial class AddServerForm : Form
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public string Pass { get; set; }
        public string User { get; set; }

        public AddServerForm()
        {
            InitializeComponent();
        }

        public void AppendInfor(string name, string ip, string user)
        {
            this.tb_Name.Text = name;
            this.tb_IP.Text = ip;
            this.tb_User.Text = user;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.Name = tb_Name.Text;
            this.IP = tb_IP.Text;
            this.Pass = tb_Pass.Text;
            this.User = tb_User.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
