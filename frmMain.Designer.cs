namespace HomeAccounting
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.miSelectAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miNewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.pnlHost = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.pnlHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolStrip1.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnSettings,
            this.toolStripSeparator1,
            this.btnExit,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAccount
            // 
            this.btnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSelectAccount,
            this.toolStripMenuItem1,
            this.miNewAccount,
            this.miEditAccount,
            this.miDeleteAccount});
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(129, 22);
            this.btnAccount.Text = "Учетная запись";
            // 
            // miSelectAccount
            // 
            this.miSelectAccount.Name = "miSelectAccount";
            this.miSelectAccount.Size = new System.Drawing.Size(220, 22);
            this.miSelectAccount.Text = "Выбрать";
            this.miSelectAccount.Click += new System.EventHandler(this.miSelectAccount_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // miNewAccount
            // 
            this.miNewAccount.Name = "miNewAccount";
            this.miNewAccount.Size = new System.Drawing.Size(220, 22);
            this.miNewAccount.Text = "Создать новую";
            this.miNewAccount.Click += new System.EventHandler(this.miNewAccount_Click);
            // 
            // miEditAccount
            // 
            this.miEditAccount.Name = "miEditAccount";
            this.miEditAccount.Size = new System.Drawing.Size(220, 22);
            this.miEditAccount.Text = "Редактировать текущую";
            this.miEditAccount.Visible = false;
            this.miEditAccount.Click += new System.EventHandler(this.miEditAccount_Click);
            // 
            // miDeleteAccount
            // 
            this.miDeleteAccount.Name = "miDeleteAccount";
            this.miDeleteAccount.Size = new System.Drawing.Size(220, 22);
            this.miDeleteAccount.Text = "Удалить текущую";
            this.miDeleteAccount.Visible = false;
            this.miDeleteAccount.Click += new System.EventHandler(this.miDeleteAccount_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(89, 22);
            this.btnSettings.Text = "Настройки";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 22);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "Справка";
            // 
            // pnlHost
            // 
            this.pnlHost.Controls.Add(this.lblLogin);
            this.pnlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHost.Location = new System.Drawing.Point(0, 25);
            this.pnlHost.Name = "pnlHost";
            this.pnlHost.Size = new System.Drawing.Size(640, 455);
            this.pnlHost.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(640, 455);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.TabStop = true;
            this.lblLogin.Text = "Выберите учетную запись";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogin_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = global::HomeAccounting.Properties.Settings.Default.MainFormSize;
            this.Controls.Add(this.pnlHost);
            this.Controls.Add(this.toolStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::HomeAccounting.Properties.Settings.Default, "GeneralFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::HomeAccounting.Properties.Settings.Default, "MainFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::HomeAccounting.Properties.Settings.Default, "MainFormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::HomeAccounting.Properties.Settings.Default.GeneralFont;
            this.Location = global::HomeAccounting.Properties.Settings.Default.MainFormLocation;
            this.Name = "frmMain";
            this.Text = "Домашняя бухгалтерия";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlHost.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripDropDownButton btnAccount;
        private System.Windows.Forms.ToolStripMenuItem miSelectAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miNewAccount;
        private System.Windows.Forms.ToolStripMenuItem miEditAccount;
        private System.Windows.Forms.ToolStripMenuItem miDeleteAccount;
        private System.Windows.Forms.Panel pnlHost;
        private System.Windows.Forms.LinkLabel lblLogin;

    }
}

