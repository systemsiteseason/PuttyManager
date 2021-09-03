using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PuttyManager
{
    public partial class TransferFile : Form
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public string Pass { get; set; }
        public string User { get; set; }
        public string PSCP { get; set; }

        public TransferFile()
        {
            InitializeComponent();
        }

        public void Append(string name, string ip, string pass, string user, string pscp)
        {
            this.Name = name;
            this.IP = ip;
            this.Pass = pass;
            this.User = user;
            this.PSCP = pscp;
            this.lb_name.Text = name;
            this.lb_ip.Text = ip;
            this.lb_user.Text = user;
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            if (cb_Folder.Checked)
            {
                var dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    tb_Patch.Text = dialog.FileName + "\\";
            }
            else
            {
                var dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dialog.FileName))
                        tb_Patch.Text = dialog.FileName;
                }
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_Patch.Text) && !string.IsNullOrEmpty(rtb_Dir.Text) && !string.IsNullOrEmpty(tb_Port.Text))
            {
                this.btn_Transfer.Enabled = false;
                var lines = this.rtb_Dir.Text.Split('\n').ToList();
                foreach(var line in lines)
                {
                    Process runTerminal = new Process();
                    runTerminal.StartInfo.FileName = PSCP;
                    runTerminal.StartInfo.Arguments = string.Concat($"-P {tb_Port.Text} -pw {Pass} -r {tb_Patch.Text} {User}@{IP}:\"{line}\"");
                    runTerminal.Start();
                }

            }
            else
            {
                MessageBox.Show("Các thông số cần thiết chưa có!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
