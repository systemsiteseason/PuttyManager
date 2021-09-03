using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuttyManager
{
    public partial class Settings : Form
    {
        public string puttyPatch { get; set; }
        public string pscpPatch { get; set; }

        public Settings()
        {
            InitializeComponent();
        }

        public void Append(string puttyP, string pscpP)
        {
            this.tb_puttyP.Text = puttyP;
            this.tb_pscpP.Text = pscpP;
        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            string PtC64 = @"C:\Program Files\PuTTY\";
            string PtC = @"C:\Program Files (x86)\PuTTY\";

            if (File.Exists(PtC64 + "putty.exe"))
                tb_puttyP.Text = PtC64 + "putty.exe";
            else if(File.Exists(PtC + "putty.exe"))
                tb_puttyP.Text = PtC + "putty.exe";

            if (File.Exists(PtC64 + "pscp.exe"))
                tb_pscpP.Text = PtC64 + "pscp.exe";
            else if (File.Exists(PtC + "pscp.exe"))
                tb_pscpP.Text = PtC + "pscp.exe";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.puttyPatch = tb_puttyP.Text;
            this.pscpPatch = tb_pscpP.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.FileName = "putty.exe";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(opf.FileName))
                {
                    tb_puttyP.Text = opf.FileName;
                    opf.FileName = "pscp.exe";
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(opf.FileName))
                        {
                            tb_pscpP.Text = opf.FileName;
                        }
                    }
                }
            }
        }
    }
}
