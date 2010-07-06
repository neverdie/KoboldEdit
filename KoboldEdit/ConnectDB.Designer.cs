namespace KoboldEdit
{
    partial class ConnectDB
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
            this._bSaveSettings = new System.Windows.Forms.Button();
            this._bTestConnect = new System.Windows.Forms.Button();
            this._gbDbSetting = new System.Windows.Forms.GroupBox();
            this._tbBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._gbDbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bSaveSettings
            // 
            this._bSaveSettings.Location = new System.Drawing.Point(136, 208);
            this._bSaveSettings.Name = "_bSaveSettings";
            this._bSaveSettings.Size = new System.Drawing.Size(95, 23);
            this._bSaveSettings.TabIndex = 11;
            this._bSaveSettings.Text = "Сохранить";
            this._bSaveSettings.UseVisualStyleBackColor = true;
            // 
            // _bTestConnect
            // 
            this._bTestConnect.Location = new System.Drawing.Point(14, 208);
            this._bTestConnect.Name = "_bTestConnect";
            this._bTestConnect.Size = new System.Drawing.Size(95, 23);
            this._bTestConnect.TabIndex = 10;
            this._bTestConnect.Text = "Проба";
            this._bTestConnect.UseVisualStyleBackColor = true;
            // 
            // _gbDbSetting
            // 
            this._gbDbSetting.Controls.Add(this._tbBase);
            this._gbDbSetting.Controls.Add(this.label5);
            this._gbDbSetting.Controls.Add(this._tbPass);
            this._gbDbSetting.Controls.Add(this.label4);
            this._gbDbSetting.Controls.Add(this._tbUser);
            this._gbDbSetting.Controls.Add(this.label3);
            this._gbDbSetting.Controls.Add(this._tbPort);
            this._gbDbSetting.Controls.Add(this.label2);
            this._gbDbSetting.Controls.Add(this._tbHost);
            this._gbDbSetting.Controls.Add(this.label1);
            this._gbDbSetting.Location = new System.Drawing.Point(14, 12);
            this._gbDbSetting.Name = "_gbDbSetting";
            this._gbDbSetting.Size = new System.Drawing.Size(217, 179);
            this._gbDbSetting.TabIndex = 8;
            this._gbDbSetting.TabStop = false;
            this._gbDbSetting.Text = "Настройки подключения к базе";
            // 
            // _tbBase
            // 
            this._tbBase.Location = new System.Drawing.Point(54, 126);
            this._tbBase.Name = "_tbBase";
            this._tbBase.Size = new System.Drawing.Size(152, 20);
            this._tbBase.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "База";
            // 
            // _tbPass
            // 
            this._tbPass.Location = new System.Drawing.Point(54, 100);
            this._tbPass.Name = "_tbPass";
            this._tbPass.Size = new System.Drawing.Size(152, 20);
            this._tbPass.TabIndex = 3;
            this._tbPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль";
            // 
            // _tbUser
            // 
            this._tbUser.Location = new System.Drawing.Point(54, 74);
            this._tbUser.Name = "_tbUser";
            this._tbUser.Size = new System.Drawing.Size(152, 20);
            this._tbUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Юзер";
            // 
            // _tbPort
            // 
            this._tbPort.Location = new System.Drawing.Point(54, 48);
            this._tbPort.Name = "_tbPort";
            this._tbPort.Size = new System.Drawing.Size(152, 20);
            this._tbPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Порт";
            // 
            // _tbHost
            // 
            this._tbHost.Location = new System.Drawing.Point(54, 22);
            this._tbHost.Name = "_tbHost";
            this._tbHost.Size = new System.Drawing.Size(152, 20);
            this._tbHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адресс";
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 243);
            this.Controls.Add(this._bSaveSettings);
            this.Controls.Add(this._bTestConnect);
            this.Controls.Add(this._gbDbSetting);
            this.Name = "ConnectDB";
            this.Text = "ConnectDB";
            this.Load += new System.EventHandler(this.ConnectDB_Load);
            this._gbDbSetting.ResumeLayout(false);
            this._gbDbSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _bSaveSettings;
        private System.Windows.Forms.Button _bTestConnect;
        private System.Windows.Forms.GroupBox _gbDbSetting;
        private System.Windows.Forms.TextBox _tbBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbHost;
        private System.Windows.Forms.Label label1;
    }
}