namespace CaznowlLauncher
{
    partial class MainForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPortal = new System.Windows.Forms.TabPage();
            this.tabTwitter = new System.Windows.Forms.TabPage();
            this.tabMinecraftUpdate = new System.Windows.Forms.TabPage();
            this.webBrowserPortal = new System.Windows.Forms.WebBrowser();
            this.webBrowserTwitter = new System.Windows.Forms.WebBrowser();
            this.webBrowserMCUpdate = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPortal.SuspendLayout();
            this.tabTwitter.SuspendLayout();
            this.tabMinecraftUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 32);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(64, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(64, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 55);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 85);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(834, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 85);
            this.panel2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPortal);
            this.tabControl1.Controls.Add(this.tabTwitter);
            this.tabControl1.Controls.Add(this.tabMinecraftUpdate);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 443);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPortal
            // 
            this.tabPortal.Controls.Add(this.webBrowserPortal);
            this.tabPortal.Location = new System.Drawing.Point(4, 22);
            this.tabPortal.Name = "tabPortal";
            this.tabPortal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPortal.Size = new System.Drawing.Size(1030, 399);
            this.tabPortal.TabIndex = 0;
            this.tabPortal.Text = "Portal";
            this.tabPortal.UseVisualStyleBackColor = true;
            // 
            // tabTwitter
            // 
            this.tabTwitter.Controls.Add(this.webBrowserTwitter);
            this.tabTwitter.Location = new System.Drawing.Point(4, 22);
            this.tabTwitter.Name = "tabTwitter";
            this.tabTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwitter.Size = new System.Drawing.Size(1030, 399);
            this.tabTwitter.TabIndex = 1;
            this.tabTwitter.Text = "Twitter";
            this.tabTwitter.UseVisualStyleBackColor = true;
            // 
            // tabMinecraftUpdate
            // 
            this.tabMinecraftUpdate.Controls.Add(this.webBrowserMCUpdate);
            this.tabMinecraftUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabMinecraftUpdate.Name = "tabMinecraftUpdate";
            this.tabMinecraftUpdate.Size = new System.Drawing.Size(1049, 417);
            this.tabMinecraftUpdate.TabIndex = 2;
            this.tabMinecraftUpdate.Text = "Minecraft Updates";
            this.tabMinecraftUpdate.UseVisualStyleBackColor = true;
            // 
            // webBrowserPortal
            // 
            this.webBrowserPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPortal.Location = new System.Drawing.Point(3, 3);
            this.webBrowserPortal.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPortal.Name = "webBrowserPortal";
            this.webBrowserPortal.Size = new System.Drawing.Size(1024, 393);
            this.webBrowserPortal.TabIndex = 0;
            this.webBrowserPortal.Url = new System.Uri("http://www.caznowl.net/portal/", System.UriKind.Absolute);
            // 
            // webBrowserTwitter
            // 
            this.webBrowserTwitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTwitter.Location = new System.Drawing.Point(3, 3);
            this.webBrowserTwitter.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTwitter.Name = "webBrowserTwitter";
            this.webBrowserTwitter.Size = new System.Drawing.Size(1024, 393);
            this.webBrowserTwitter.TabIndex = 0;
            this.webBrowserTwitter.Url = new System.Uri("http://twitter.com/caznowl/", System.UriKind.Absolute);
            // 
            // webBrowserMCUpdate
            // 
            this.webBrowserMCUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMCUpdate.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMCUpdate.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMCUpdate.Name = "webBrowserMCUpdate";
            this.webBrowserMCUpdate.Size = new System.Drawing.Size(1049, 417);
            this.webBrowserMCUpdate.TabIndex = 0;
            this.webBrowserMCUpdate.Url = new System.Uri("http://mcupdate.tumblr.com/", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Caznowl Launcher";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPortal.ResumeLayout(false);
            this.tabTwitter.ResumeLayout(false);
            this.tabMinecraftUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPortal;
        private System.Windows.Forms.WebBrowser webBrowserPortal;
        private System.Windows.Forms.TabPage tabTwitter;
        private System.Windows.Forms.TabPage tabMinecraftUpdate;
        private System.Windows.Forms.WebBrowser webBrowserTwitter;
        private System.Windows.Forms.WebBrowser webBrowserMCUpdate;
    }
}

