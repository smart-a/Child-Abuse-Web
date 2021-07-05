
namespace ChildAbuse.Admin.Dashboard
{
    partial class WhistleDetails
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
            this.panelWhistle = new Wisej.Web.Panel();
            this.lblWhistle = new Wisej.Web.Label();
            this.panelWhistle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWhistle
            // 
            this.panelWhistle.AutoScroll = true;
            this.panelWhistle.Controls.Add(this.lblWhistle);
            this.panelWhistle.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelWhistle.Location = new System.Drawing.Point(33, 23);
            this.panelWhistle.Name = "panelWhistle";
            this.panelWhistle.Padding = new Wisej.Web.Padding(10);
            this.panelWhistle.ScrollBars = Wisej.Web.ScrollBars.Vertical;
            this.panelWhistle.ShowCloseButton = false;
            this.panelWhistle.ShowHeader = true;
            this.panelWhistle.Size = new System.Drawing.Size(532, 435);
            this.panelWhistle.TabIndex = 0;
            this.panelWhistle.TabStop = true;
            this.panelWhistle.Text = "Whistle Blown";
            // 
            // lblWhistle
            // 
            this.lblWhistle.AllowHtml = true;
            this.lblWhistle.AutoSize = true;
            this.lblWhistle.Dock = Wisej.Web.DockStyle.Fill;
            this.lblWhistle.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWhistle.Location = new System.Drawing.Point(10, 10);
            this.lblWhistle.Name = "lblWhistle";
            this.lblWhistle.Padding = new Wisej.Web.Padding(10);
            this.lblWhistle.Size = new System.Drawing.Size(512, 387);
            this.lblWhistle.TabIndex = 0;
            // 
            // WhistleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 479);
            this.Controls.Add(this.panelWhistle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WhistleDetails";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "WhistleDetails";
            this.Load += new System.EventHandler(this.WhistleDetails_Load);
            this.panelWhistle.ResumeLayout(false);
            this.panelWhistle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panelWhistle;
        private Wisej.Web.Label lblWhistle;
    }
}