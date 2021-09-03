using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuttyManager
{
    public partial class MainApp : Form
    {
        private string pKey;
        private string puttyPatch;
        private string pscpPatch;
        private string databaseFile;
        private BindingList<ServerStruct> listserver = new BindingList<ServerStruct>();

        private class ServerStruct
        {
            public string Name { get; set; }
            public string IP { get; set; }
            public string Password { get; set; }
            public string User { get; set; }
        }

        public MainApp()
        {
            InitializeComponent();
        }

        public void InputKey(string key)
        {
            pKey = key;
        }

        public void GetSettings()
        {
            if (!File.Exists("config.ini"))
            {
                databaseFile = AesOperation.EncryptString(pKey, "database_dontshare") + ".bs";
                var ct = new FileIniDataParser();
                IniData data = new IniData();
                data["PuttyDir"]["putty"] = "";
                data["PuttyDir"]["pscp"] = "";
                data["DataContruct"]["database"] = databaseFile;
                StreamWriter wt = new StreamWriter(databaseFile);
                wt.Close();
                ct.WriteFile("config.ini", data);
                
            }
            else
            {
                var ct = new FileIniDataParser();
                IniData data = ct.ReadFile("config.ini");
                puttyPatch = data["PuttyDir"]["putty"];
                pscpPatch = data["PuttyDir"]["pscp"];
                databaseFile = data["DataContruct"]["database"];
                try
                {
                    if (AesOperation.DecryptString(pKey, Path.GetFileNameWithoutExtension(databaseFile)) != "database_dontshare")
                    {
                        MessageBox.Show("Sai mã bảo mật!");
                        Application.Exit();
                    }
                }
                catch
                {
                    MessageBox.Show("Sai mã bảo mật!");
                    Application.Exit();
                }
                string dataTxt = AesOperation.DecryptString(pKey, File.ReadAllText(databaseFile));
                using (CsvFileReader reader = new CsvFileReader(new MemoryStream(Encoding.UTF8.GetBytes(dataTxt))))
                {
                    CsvRow row = new CsvRow();
                    while (reader.ReadRow(row))
                    {
                        listserver.Add(new ServerStruct { Name = row[0], IP = row[1], Password = row[2], User = row[3] });
                    }
                }
            }
            dataStr.DataSource = listserver;

            dataStr.Columns[2].Visible = false;
        }

        public void AddServer(string name, string ip, string pass, string user)
        {
            listserver.Add(new ServerStruct { Name = name, IP = ip, Password = pass, User = user });
            UpdateServer();
        }

        public void EditServer(string name, string ip, string pass, string user)
        {
            listserver[dataStr.CurrentCell.RowIndex] = new ServerStruct { Name = name, IP = ip, Password = pass, User = user };
            UpdateServer();
        }

        public void UpdateServer()
        {
            dataStr.Update();
            dataStr.Refresh();
            using (var wt = new StreamWriter(databaseFile))
            {
                MemoryStream ms = new MemoryStream();
                using (CsvFileWriter writer = new CsvFileWriter(ms))
                {
                    for (int i = 0; i < listserver.Count; i++)
                    {
                        CsvRow row = new CsvRow();
                        row.Add(listserver[i].Name);
                        row.Add(listserver[i].IP);
                        row.Add(listserver[i].Password);
                        row.Add(listserver[i].User);
                        writer.WriteRow(row);
                    }
                }
                wt.Write(AesOperation.EncryptString(pKey, Encoding.UTF8.GetString(ms.ToArray())));
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            using (var form = new AddServerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AddServer(form.Name, form.IP, form.Pass, form.User);
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (listserver.Count < 1)
                return;
            listserver.RemoveAt(dataStr.CurrentCell.RowIndex);
            UpdateServer();
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (listserver.Count < 1)
                return;
            using (var form = new AddServerForm())
            {
                form.AppendInfor(listserver[dataStr.CurrentCell.RowIndex].Name, listserver[dataStr.CurrentCell.RowIndex].IP, listserver[dataStr.CurrentCell.RowIndex].User);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string pss = string.Empty;
                    if (!string.IsNullOrEmpty(form.Pass))
                        pss = listserver[dataStr.CurrentCell.RowIndex].Password;
                    else
                        pss = form.Pass;
                    EditServer(form.Name, form.IP, pss, form.User);

                }
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            using (var form = new Settings())
            {
                form.Append(puttyPatch, pscpPatch);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    puttyPatch = form.puttyPatch;
                    pscpPatch = form.pscpPatch;
                    var ct = new FileIniDataParser();
                    IniData data = ct.ReadFile("config.ini");
                    data["PuttyDir"]["putty"] = puttyPatch;
                    data["PuttyDir"]["pscp"] = pscpPatch;
                    ct.WriteFile("config.ini", data);
                }
            }
        }

        private void btn_SSH_Click(object sender, EventArgs e)
        {
            if(listserver.Count < 1 || string.IsNullOrEmpty(puttyPatch))
            {
                MessageBox.Show("Không có server nào hoặc đường dẫn đến putty.exe chưa có!");
                return;
            }

            Process runTerminal = new Process();
            runTerminal.StartInfo.UseShellExecute = true;
            runTerminal.StartInfo.FileName = puttyPatch;
            runTerminal.StartInfo.Arguments = string.Concat($" {listserver[dataStr.CurrentCell.RowIndex].User}@{listserver[dataStr.CurrentCell.RowIndex].IP} -pw {listserver[dataStr.CurrentCell.RowIndex].Password}");
            runTerminal.Start();
        }

        private void btn_PSCP_Click(object sender, EventArgs e)
        {
            if (listserver.Count < 1 || string.IsNullOrEmpty(pscpPatch))
            {
                MessageBox.Show("Không có server nào hoặc đường dẫn đến pscp.exe chưa có!");
                return;
            }
            using (var form = new TransferFile())
            {
                form.Append(listserver[dataStr.CurrentCell.RowIndex].Name, listserver[dataStr.CurrentCell.RowIndex].IP, listserver[dataStr.CurrentCell.RowIndex].Password, listserver[dataStr.CurrentCell.RowIndex].User, pscpPatch);

                var result = form.ShowDialog();
            }
        }
    }
}
