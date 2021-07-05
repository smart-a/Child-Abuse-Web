
namespace ChildAbuse.Components
{
    partial class WhistleBlowerForm
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
            this.panelUserInfo = new Wisej.Web.Panel();
            this.txtContact = new Wisej.Web.TextBox();
            this.txtWho = new Wisej.Web.TextBox();
            this.txtWhere = new Wisej.Web.TextBox();
            this.txtWhen = new Wisej.Web.TextBox();
            this.btnSubmit = new Wisej.Web.Button();
            this.txtWhat = new Wisej.Web.TextBox();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Controls.Add(this.txtContact);
            this.panelUserInfo.Controls.Add(this.txtWho);
            this.panelUserInfo.Controls.Add(this.txtWhere);
            this.panelUserInfo.Controls.Add(this.txtWhen);
            this.panelUserInfo.Controls.Add(this.btnSubmit);
            this.panelUserInfo.Controls.Add(this.txtWhat);
            this.panelUserInfo.Location = new System.Drawing.Point(25, 19);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(481, 558);
            this.panelUserInfo.TabIndex = 40;
            this.panelUserInfo.TabStop = true;
            // 
            // txtContact
            // 
            this.txtContact.CssStyle = "border-radius: 3px";
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.LabelText = "Please give your name and contact details. (Protection guaranteed)";
            this.txtContact.Location = new System.Drawing.Point(22, 395);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Padding = new Wisej.Web.Padding(12);
            this.txtContact.Size = new System.Drawing.Size(433, 103);
            this.txtContact.TabIndex = 40;
            this.txtContact.Watermark = "You can remain anonymous, but you are urged to identify yourself so that we can c" +
    "ontact you for mere additional information necessary for appropriate review of y" +
    "our disclosure.";
            // 
            // txtWho
            // 
            this.txtWho.CssStyle = "border-radius: 3px";
            this.txtWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWho.LabelText = "Who are the relevant persons and/or entities involved?";
            this.txtWho.Location = new System.Drawing.Point(22, 287);
            this.txtWho.Multiline = true;
            this.txtWho.Name = "txtWho";
            this.txtWho.Padding = new Wisej.Web.Padding(12);
            this.txtWho.Size = new System.Drawing.Size(433, 102);
            this.txtWho.TabIndex = 39;
            this.txtWho.Watermark = "Specifying names and details of people or companies, who are involved or have bec" +
    "ome aware of alleged wrongdoing.";
            // 
            // txtWhere
            // 
            this.txtWhere.CssStyle = "border-radius: 3px";
            this.txtWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWhere.InputType.Type = Wisej.Web.TextBoxType.Email;
            this.txtWhere.LabelText = "Where did it happen?";
            this.txtWhere.Location = new System.Drawing.Point(22, 199);
            this.txtWhere.Multiline = true;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Padding = new Wisej.Web.Padding(12);
            this.txtWhere.Size = new System.Drawing.Size(433, 82);
            this.txtWhere.TabIndex = 38;
            this.txtWhere.Watermark = "Specifying where and when wrongdoing took place (country, city, area...).";
            // 
            // txtWhen
            // 
            this.txtWhen.CssStyle = "border-radius: 3px";
            this.txtWhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWhen.LabelText = " When did it happen?";
            this.txtWhen.Location = new System.Drawing.Point(21, 108);
            this.txtWhen.Multiline = true;
            this.txtWhen.Name = "txtWhen";
            this.txtWhen.Padding = new Wisej.Web.Padding(12);
            this.txtWhen.Size = new System.Drawing.Size(434, 85);
            this.txtWhen.TabIndex = 37;
            this.txtWhen.Watermark = "Specifying date, time and other personal details.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(92, 186, 60);
            this.btnSubmit.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSubmit.Location = new System.Drawing.Point(366, 514);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 30);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Send";
            this.btnSubmit.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWhat
            // 
            this.txtWhat.CssStyle = "border-radius: 3px";
            this.txtWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWhat.InputType.Type = Wisej.Web.TextBoxType.Email;
            this.txtWhat.LabelText = "What happened?";
            this.txtWhat.Location = new System.Drawing.Point(22, 14);
            this.txtWhat.Multiline = true;
            this.txtWhat.Name = "txtWhat";
            this.txtWhat.Padding = new Wisej.Web.Padding(12);
            this.txtWhat.Size = new System.Drawing.Size(433, 88);
            this.txtWhat.TabIndex = 36;
            this.txtWhat.Watermark = "Full description of the facts including all useful details.";
            // 
            // WhistleBlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 589);
            this.Controls.Add(this.panelUserInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WhistleBlowerForm";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "WhistleBlower";
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelUserInfo;
        private Wisej.Web.TextBox txtWhen;
        private Wisej.Web.TextBox txtWhat;
        private Wisej.Web.Button btnSubmit;
        private Wisej.Web.TextBox txtContact;
        private Wisej.Web.TextBox txtWho;
        private Wisej.Web.TextBox txtWhere;
    }
}