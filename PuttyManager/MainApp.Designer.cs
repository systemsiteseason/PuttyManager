
namespace PuttyManager
{
    partial class MainApp
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_SSH = new System.Windows.Forms.Button();
            this.btn_PSCP = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.dataStr = new System.Windows.Forms.DataGridView();
            this.btn_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStr)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(109, 357);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(53, 23);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_SSH
            // 
            this.btn_SSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SSH.Location = new System.Drawing.Point(12, 12);
            this.btn_SSH.Name = "btn_SSH";
            this.btn_SSH.Size = new System.Drawing.Size(150, 110);
            this.btn_SSH.TabIndex = 3;
            this.btn_SSH.Text = "Cửa sổ Terminal Putty";
            this.btn_SSH.UseVisualStyleBackColor = true;
            this.btn_SSH.Click += new System.EventHandler(this.btn_SSH_Click);
            // 
            // btn_PSCP
            // 
            this.btn_PSCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PSCP.Location = new System.Drawing.Point(12, 128);
            this.btn_PSCP.Name = "btn_PSCP";
            this.btn_PSCP.Size = new System.Drawing.Size(150, 110);
            this.btn_PSCP.TabIndex = 4;
            this.btn_PSCP.Text = "Tải lên/Tải xuống FIle";
            this.btn_PSCP.UseVisualStyleBackColor = true;
            this.btn_PSCP.Click += new System.EventHandler(this.btn_PSCP_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(109, 415);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(53, 23);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(13, 244);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(149, 48);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.Text = "Cài đặt";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // dataStr
            // 
            this.dataStr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStr.Location = new System.Drawing.Point(168, 12);
            this.dataStr.Name = "dataStr";
            this.dataStr.ReadOnly = true;
            this.dataStr.Size = new System.Drawing.Size(482, 426);
            this.dataStr.TabIndex = 0;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(109, 386);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(53, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_PSCP);
            this.Controls.Add(this.btn_SSH);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Putty Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_SSH;
        private System.Windows.Forms.Button btn_PSCP;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.DataGridView dataStr;
        private System.Windows.Forms.Button btn_Edit;
    }
}