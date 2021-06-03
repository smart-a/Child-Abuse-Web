
namespace ChildAbuse.Admin
{
    partial class AdminLogin
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.panel7 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panelMsg = new Wisej.Web.Panel();
            this.lblMsg = new Wisej.Web.Label();
            this.btnCloseMsg = new Wisej.Web.Button();
            this.btnProceed = new Wisej.Web.Button();
            this.txtPassword = new Wisej.Web.TextBox();
            this.txtUsername = new Wisej.Web.TextBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.panelMsg);
            this.panel7.Controls.Add(this.btnProceed);
            this.panel7.Controls.Add(this.txtPassword);
            this.panel7.Controls.Add(this.txtUsername);
            this.panel7.Location = new System.Drawing.Point(102, 41);
            this.panel7.Name = "panel7";
            this.panel7.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel7.ResponsiveProfiles"))));
            this.panel7.Size = new System.Drawing.Size(597, 471);
            this.panel7.TabIndex = 3;
            this.panel7.TabStop = true;
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(102, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admin Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.pictureBox1.Image = global::ChildAbuse.Properties.Resources.NIgerian_police;
            this.pictureBox1.Location = new System.Drawing.Point(250, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 77);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panelMsg
            // 
            this.panelMsg.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panelMsg.BackColor = System.Drawing.Color.FromArgb(248, 215, 218);
            this.panelMsg.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelMsg.Controls.Add(this.lblMsg);
            this.panelMsg.Controls.Add(this.btnCloseMsg);
            this.panelMsg.CssStyle = "border-radius: 4px";
            this.panelMsg.Location = new System.Drawing.Point(102, 142);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelMsg.ResponsiveProfiles"))));
            this.panelMsg.ShowCloseButton = false;
            this.panelMsg.Size = new System.Drawing.Size(398, 60);
            this.panelMsg.TabIndex = 8;
            this.panelMsg.TabStop = true;
            this.panelMsg.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.FromArgb(248, 215, 217);
            this.lblMsg.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(153, 45, 36);
            this.lblMsg.Location = new System.Drawing.Point(18, 19);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("lblMsg.ResponsiveProfiles"))));
            this.lblMsg.Size = new System.Drawing.Size(96, 21);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Some Error";
            // 
            // btnCloseMsg
            // 
            this.btnCloseMsg.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Right)));
            this.btnCloseMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseMsg.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnCloseMsg.Focusable = false;
            this.btnCloseMsg.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCloseMsg.ForeColor = System.Drawing.Color.FromArgb(153, 45, 36);
            this.btnCloseMsg.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times.svg";
            this.btnCloseMsg.Location = new System.Drawing.Point(358, 10);
            this.btnCloseMsg.Name = "btnCloseMsg";
            this.btnCloseMsg.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnCloseMsg.ResponsiveProfiles"))));
            this.btnCloseMsg.Size = new System.Drawing.Size(30, 38);
            this.btnCloseMsg.TabIndex = 0;
            this.btnCloseMsg.Click += new System.EventHandler(this.btnMsgClose_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.AllowHtml = true;
            this.btnProceed.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(0, 0, 51);
            this.btnProceed.CssStyle = "border-radius: 4px";
            this.btnProceed.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnProceed.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/check-square-o.svg";
            this.btnProceed.Location = new System.Drawing.Point(102, 373);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnProceed.ResponsiveProfiles"))));
            this.btnProceed.Size = new System.Drawing.Size(397, 56);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed    ";
            this.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProceed.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtPassword.CssStyle = "border-radius: 4px";
            this.txtPassword.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txtPassword.Location = new System.Drawing.Point(102, 294);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new Wisej.Web.Padding(15);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtPassword.ResponsiveProfiles"))));
            this.txtPassword.Size = new System.Drawing.Size(397, 53);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Watermark = "Enter Password";
            this.txtPassword.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = Wisej.Web.AnchorStyles.Top;
            this.txtUsername.CssStyle = "border-radius: 4px";
            this.txtUsername.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Location = new System.Drawing.Point(102, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new Wisej.Web.Padding(15);
            this.txtUsername.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtUsername.ResponsiveProfiles"))));
            this.txtUsername.Size = new System.Drawing.Size(397, 53);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Watermark = "Enter Username";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel7;
        private Wisej.Web.Label label1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Panel panelMsg;
        private Wisej.Web.Label lblMsg;
        private Wisej.Web.Button btnCloseMsg;
        private Wisej.Web.Button btnProceed;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.TextBox txtUsername;
    }
}