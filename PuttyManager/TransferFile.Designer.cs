
namespace PuttyManager
{
    partial class TransferFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Folder = new System.Windows.Forms.CheckBox();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.tb_Patch = new System.Windows.Forms.TextBox();
            this.rd_Download = new System.Windows.Forms.RadioButton();
            this.rd_Upload = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_Manual = new System.Windows.Forms.RadioButton();
            this.rtb_Dir = new System.Windows.Forms.RichTextBox();
            this.rd_Second = new System.Windows.Forms.RadioButton();
            this.rd_First = new System.Windows.Forms.RadioButton();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Folder);
            this.groupBox1.Controls.Add(this.btn_Browser);
            this.groupBox1.Controls.Add(this.tb_Patch);
            this.groupBox1.Controls.Add(this.rd_Download);
            this.groupBox1.Controls.Add(this.rd_Upload);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer";
            // 
            // cb_Folder
            // 
            this.cb_Folder.AutoSize = true;
            this.cb_Folder.Location = new System.Drawing.Point(369, 60);
            this.cb_Folder.Name = "cb_Folder";
            this.cb_Folder.Size = new System.Drawing.Size(92, 17);
            this.cb_Folder.TabIndex = 4;
            this.cb_Folder.Text = "Upload Folder";
            this.cb_Folder.UseVisualStyleBackColor = true;
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(409, 25);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(52, 29);
            this.btn_Browser.TabIndex = 3;
            this.btn_Browser.Text = "...";
            this.btn_Browser.UseVisualStyleBackColor = true;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // tb_Patch
            // 
            this.tb_Patch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Patch.Location = new System.Drawing.Point(113, 25);
            this.tb_Patch.Name = "tb_Patch";
            this.tb_Patch.ReadOnly = true;
            this.tb_Patch.Size = new System.Drawing.Size(290, 29);
            this.tb_Patch.TabIndex = 2;
            // 
            // rd_Download
            // 
            this.rd_Download.AutoSize = true;
            this.rd_Download.Enabled = false;
            this.rd_Download.Location = new System.Drawing.Point(22, 42);
            this.rd_Download.Name = "rd_Download";
            this.rd_Download.Size = new System.Drawing.Size(72, 17);
            this.rd_Download.TabIndex = 1;
            this.rd_Download.Text = "Tải xuống";
            this.rd_Download.UseVisualStyleBackColor = true;
            // 
            // rd_Upload
            // 
            this.rd_Upload.AutoSize = true;
            this.rd_Upload.Checked = true;
            this.rd_Upload.Location = new System.Drawing.Point(22, 19);
            this.rd_Upload.Name = "rd_Upload";
            this.rd_Upload.Size = new System.Drawing.Size(57, 17);
            this.rd_Upload.TabIndex = 0;
            this.rd_Upload.TabStop = true;
            this.rd_Upload.Text = "Tải lên";
            this.rd_Upload.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_Manual);
            this.groupBox2.Controls.Add(this.rtb_Dir);
            this.groupBox2.Controls.Add(this.rd_Second);
            this.groupBox2.Controls.Add(this.rd_First);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 220);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // rd_Manual
            // 
            this.rd_Manual.AutoSize = true;
            this.rd_Manual.Checked = true;
            this.rd_Manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Manual.Location = new System.Drawing.Point(22, 71);
            this.rd_Manual.Name = "rd_Manual";
            this.rd_Manual.Size = new System.Drawing.Size(30, 20);
            this.rd_Manual.TabIndex = 6;
            this.rd_Manual.TabStop = true;
            this.rd_Manual.Text = ".";
            this.rd_Manual.UseVisualStyleBackColor = true;
            // 
            // rtb_Dir
            // 
            this.rtb_Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Dir.Location = new System.Drawing.Point(71, 18);
            this.rtb_Dir.Name = "rtb_Dir";
            this.rtb_Dir.Size = new System.Drawing.Size(390, 196);
            this.rtb_Dir.TabIndex = 5;
            this.rtb_Dir.Text = "";
            // 
            // rd_Second
            // 
            this.rd_Second.AutoSize = true;
            this.rd_Second.Enabled = false;
            this.rd_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Second.Location = new System.Drawing.Point(22, 48);
            this.rd_Second.Name = "rd_Second";
            this.rd_Second.Size = new System.Drawing.Size(31, 20);
            this.rd_Second.TabIndex = 1;
            this.rd_Second.Text = "/";
            this.rd_Second.UseVisualStyleBackColor = true;
            // 
            // rd_First
            // 
            this.rd_First.AutoSize = true;
            this.rd_First.Enabled = false;
            this.rd_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_First.Location = new System.Drawing.Point(22, 25);
            this.rd_First.Name = "rd_First";
            this.rd_First.Size = new System.Drawing.Size(36, 20);
            this.rd_First.TabIndex = 0;
            this.rd_First.Text = "~";
            this.rd_First.UseVisualStyleBackColor = true;
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(223, 343);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(27, 20);
            this.tb_Port.TabIndex = 3;
            this.tb_Port.Text = "22";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transfer.Location = new System.Drawing.Point(259, 331);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(107, 39);
            this.btn_Transfer.TabIndex = 5;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(372, 331);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Done";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(15, 333);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 13);
            this.lb_name.TabIndex = 7;
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(15, 346);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(0, 13);
            this.lb_ip.TabIndex = 8;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(15, 359);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(0, 13);
            this.lb_user.TabIndex = 9;
            // 
            // TransferFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 382);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferFile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Patch;
        private System.Windows.Forms.RadioButton rd_Download;
        private System.Windows.Forms.RadioButton rd_Upload;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_Dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.RadioButton rd_Second;
        private System.Windows.Forms.RadioButton rd_First;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rd_Manual;
        private System.Windows.Forms.CheckBox cb_Folder;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_user;
    }
}