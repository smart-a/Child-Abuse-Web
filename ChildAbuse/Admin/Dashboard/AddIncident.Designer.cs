
namespace ChildAbuse.Admin.Dashboard
{
    partial class AddIncident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncident));
            this.panel1 = new Wisej.Web.Panel();
            this.panel6 = new Wisej.Web.Panel();
            this.cbVictimGender = new Wisej.Web.ComboBox();
            this.txtVictimAge = new Wisej.Web.TextBox();
            this.txtVictimName = new Wisej.Web.TextBox();
            this.upload1 = new Wisej.Web.Upload();
            this.pbVictimImage = new Wisej.Web.PictureBox();
            this.panel3 = new Wisej.Web.Panel();
            this.panel5 = new Wisej.Web.Panel();
            this.dtpCrimeDate = new Wisej.Web.DateTimePicker();
            this.panel4 = new Wisej.Web.Panel();
            this.cbCrimeCategory = new Wisej.Web.ComboBox();
            this.txtCrimeLocation = new Wisej.Web.TextBox();
            this.panel2 = new Wisej.Web.Panel();
            this.txtCurpritAddress = new Wisej.Web.TextBox();
            this.panel7 = new Wisej.Web.Panel();
            this.cbCurpritGender = new Wisej.Web.ComboBox();
            this.txtCurpritAge = new Wisej.Web.TextBox();
            this.txtCurpritName = new Wisej.Web.TextBox();
            this.upload2 = new Wisej.Web.Upload();
            this.pbCurpritImage = new Wisej.Web.PictureBox();
            this.btnSave = new Wisej.Web.Button();
            this.btnReset = new Wisej.Web.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVictimImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurpritImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.txtVictimAge);
            this.panel1.Controls.Add(this.txtVictimName);
            this.panel1.Controls.Add(this.upload1);
            this.panel1.Controls.Add(this.pbVictimImage);
            this.panel1.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(0, 0, 51);
            this.panel1.Location = new System.Drawing.Point(25, 203);
            this.panel1.Name = "panel1";
            this.panel1.ShowCloseButton = false;
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(649, 200);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            this.panel1.Text = "Victim Details";
            // 
            // panel6
            // 
            this.panel6.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel6.Controls.Add(this.cbVictimGender);
            this.panel6.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel6.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel6.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel6.Location = new System.Drawing.Point(32, 85);
            this.panel6.Name = "panel6";
            this.panel6.ShowCloseButton = false;
            this.panel6.ShowHeader = true;
            this.panel6.Size = new System.Drawing.Size(197, 65);
            this.panel6.TabIndex = 19;
            this.panel6.TabStop = true;
            this.panel6.Text = "Gender";
            // 
            // cbVictimGender
            // 
            this.cbVictimGender.AutoSize = false;
            this.cbVictimGender.CssStyle = "padding: 10px;";
            this.cbVictimGender.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbVictimGender.Location = new System.Drawing.Point(4, 5);
            this.cbVictimGender.Name = "cbVictimGender";
            this.cbVictimGender.Size = new System.Drawing.Size(190, 29);
            this.cbVictimGender.TabIndex = 9;
            this.cbVictimGender.Watermark = "Select Gender";
            // 
            // txtVictimAge
            // 
            this.txtVictimAge.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVictimAge.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txtVictimAge.LabelText = "Age";
            this.txtVictimAge.Location = new System.Drawing.Point(252, 95);
            this.txtVictimAge.Name = "txtVictimAge";
            this.txtVictimAge.Padding = new Wisej.Web.Padding(5);
            this.txtVictimAge.Size = new System.Drawing.Size(116, 52);
            this.txtVictimAge.TabIndex = 16;
            this.txtVictimAge.Watermark = "Enter age";
            // 
            // txtVictimName
            // 
            this.txtVictimName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVictimName.LabelText = "Victim Fullame";
            this.txtVictimName.Location = new System.Drawing.Point(33, 11);
            this.txtVictimName.Name = "txtVictimName";
            this.txtVictimName.Padding = new Wisej.Web.Padding(5);
            this.txtVictimName.Size = new System.Drawing.Size(338, 54);
            this.txtVictimName.TabIndex = 15;
            this.txtVictimName.Watermark = "Enter victim name";
            // 
            // upload1
            // 
            this.upload1.HideValue = true;
            this.upload1.Location = new System.Drawing.Point(485, 128);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(123, 23);
            this.upload1.TabIndex = 1;
            this.upload1.Text = "Upload";
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // pbVictimImage
            // 
            this.pbVictimImage.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbVictimImage.Location = new System.Drawing.Point(485, 11);
            this.pbVictimImage.Name = "pbVictimImage";
            this.pbVictimImage.Size = new System.Drawing.Size(123, 111);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtCrimeLocation);
            this.panel3.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.HeaderBackColor = System.Drawing.Color.FromArgb(0, 0, 51);
            this.panel3.Location = new System.Drawing.Point(25, 21);
            this.panel3.Name = "panel3";
            this.panel3.ShowCloseButton = false;
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(649, 176);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            this.panel3.Text = "Incident Details";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpCrimeDate);
            this.panel5.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel5.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel5.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel5.Location = new System.Drawing.Point(387, 9);
            this.panel5.Name = "panel5";
            this.panel5.ShowCloseButton = false;
            this.panel5.ShowHeader = true;
            this.panel5.Size = new System.Drawing.Size(224, 65);
            this.panel5.TabIndex = 20;
            this.panel5.TabStop = true;
            this.panel5.Text = "Date";
            // 
            // dtpCrimeDate
            // 
            this.dtpCrimeDate.AutoSize = false;
            this.dtpCrimeDate.Checked = false;
            this.dtpCrimeDate.CustomFormat = "ddd dd MMM, yyyy";
            this.dtpCrimeDate.Format = Wisej.Web.DateTimePickerFormat.Custom;
            this.dtpCrimeDate.Location = new System.Drawing.Point(3, 4);
            this.dtpCrimeDate.Name = "dtpCrimeDate";
            this.dtpCrimeDate.Size = new System.Drawing.Size(218, 29);
            this.dtpCrimeDate.TabIndex = 19;
            this.dtpCrimeDate.Value = new System.DateTime(2021, 6, 2, 14, 32, 35, 364);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbCrimeCategory);
            this.panel4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel4.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel4.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel4.Location = new System.Drawing.Point(30, 9);
            this.panel4.Name = "panel4";
            this.panel4.ShowCloseButton = false;
            this.panel4.ShowHeader = true;
            this.panel4.Size = new System.Drawing.Size(327, 65);
            this.panel4.TabIndex = 18;
            this.panel4.TabStop = true;
            this.panel4.Text = "Category";
            // 
            // cbCrimeCategory
            // 
            this.cbCrimeCategory.AutoSize = false;
            this.cbCrimeCategory.CssStyle = "padding: 10px;";
            this.cbCrimeCategory.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCrimeCategory.Items.AddRange(new object[] {
            ((object)(resources.GetObject("cbCrimeCategory.Items")))});
            this.cbCrimeCategory.Location = new System.Drawing.Point(8, 4);
            this.cbCrimeCategory.Name = "cbCrimeCategory";
            this.cbCrimeCategory.Size = new System.Drawing.Size(316, 29);
            this.cbCrimeCategory.TabIndex = 9;
            this.cbCrimeCategory.Watermark = "Select crime category";
            // 
            // txtCrimeLocation
            // 
            this.txtCrimeLocation.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCrimeLocation.LabelText = "Crime Location";
            this.txtCrimeLocation.Location = new System.Drawing.Point(33, 84);
            this.txtCrimeLocation.Name = "txtCrimeLocation";
            this.txtCrimeLocation.Padding = new Wisej.Web.Padding(5);
            this.txtCrimeLocation.Size = new System.Drawing.Size(578, 52);
            this.txtCrimeLocation.TabIndex = 15;
            this.txtCrimeLocation.Watermark = "Enter location details";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel2.Controls.Add(this.txtCurpritAddress);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtCurpritAge);
            this.panel2.Controls.Add(this.txtCurpritName);
            this.panel2.Controls.Add(this.upload2);
            this.panel2.Controls.Add(this.pbCurpritImage);
            this.panel2.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.HeaderBackColor = System.Drawing.Color.FromArgb(0, 0, 51);
            this.panel2.Location = new System.Drawing.Point(25, 409);
            this.panel2.Name = "panel2";
            this.panel2.ShowCloseButton = false;
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(649, 262);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            this.panel2.Text = "Curprit Details";
            // 
            // txtCurpritAddress
            // 
            this.txtCurpritAddress.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurpritAddress.LabelText = "Curprit Address";
            this.txtCurpritAddress.Location = new System.Drawing.Point(32, 168);
            this.txtCurpritAddress.Name = "txtCurpritAddress";
            this.txtCurpritAddress.Padding = new Wisej.Web.Padding(5);
            this.txtCurpritAddress.Size = new System.Drawing.Size(579, 52);
            this.txtCurpritAddress.TabIndex = 21;
            this.txtCurpritAddress.Watermark = "Enter curprit address";
            // 
            // panel7
            // 
            this.panel7.Anchor = Wisej.Web.AnchorStyles.Top;
            this.panel7.Controls.Add(this.cbCurpritGender);
            this.panel7.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel7.HeaderBackColor = System.Drawing.Color.Transparent;
            this.panel7.HeaderForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.panel7.Location = new System.Drawing.Point(32, 85);
            this.panel7.Name = "panel7";
            this.panel7.ShowCloseButton = false;
            this.panel7.ShowHeader = true;
            this.panel7.Size = new System.Drawing.Size(197, 65);
            this.panel7.TabIndex = 19;
            this.panel7.TabStop = true;
            this.panel7.Text = "Gender";
            // 
            // cbCurpritGender
            // 
            this.cbCurpritGender.AutoSize = false;
            this.cbCurpritGender.CssStyle = "padding: 10px;";
            this.cbCurpritGender.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbCurpritGender.Location = new System.Drawing.Point(3, 5);
            this.cbCurpritGender.Name = "cbCurpritGender";
            this.cbCurpritGender.Size = new System.Drawing.Size(180, 29);
            this.cbCurpritGender.TabIndex = 9;
            this.cbCurpritGender.Watermark = "Select Gender";
            // 
            // txtCurpritAge
            // 
            this.txtCurpritAge.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurpritAge.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txtCurpritAge.LabelText = "Age";
            this.txtCurpritAge.Location = new System.Drawing.Point(252, 95);
            this.txtCurpritAge.Name = "txtCurpritAge";
            this.txtCurpritAge.Padding = new Wisej.Web.Padding(5);
            this.txtCurpritAge.Size = new System.Drawing.Size(116, 52);
            this.txtCurpritAge.TabIndex = 16;
            this.txtCurpritAge.Watermark = "Enter age";
            // 
            // txtCurpritName
            // 
            this.txtCurpritName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCurpritName.LabelText = "Curprit Fullame";
            this.txtCurpritName.Location = new System.Drawing.Point(33, 11);
            this.txtCurpritName.Name = "txtCurpritName";
            this.txtCurpritName.Padding = new Wisej.Web.Padding(5);
            this.txtCurpritName.Size = new System.Drawing.Size(338, 54);
            this.txtCurpritName.TabIndex = 15;
            this.txtCurpritName.Watermark = "Enter victim name";
            // 
            // upload2
            // 
            this.upload2.HideValue = true;
            this.upload2.Location = new System.Drawing.Point(485, 128);
            this.upload2.Name = "upload2";
            this.upload2.Size = new System.Drawing.Size(123, 23);
            this.upload2.TabIndex = 1;
            this.upload2.Text = "Upload";
            this.upload2.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload2_Uploaded);
            // 
            // pbCurpritImage
            // 
            this.pbCurpritImage.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pbCurpritImage.Location = new System.Drawing.Point(485, 11);
            this.pbCurpritImage.Name = "pbCurpritImage";
            this.pbCurpritImage.Size = new System.Drawing.Size(123, 111);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/hand-o-up.svg";
            this.btnSave.Location = new System.Drawing.Point(510, 691);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Record";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/times-circle-o.svg";
            this.btnReset.Location = new System.Drawing.Point(25, 691);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 753);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.HeaderBackColor = System.Drawing.Color.FromArgb(0, 0, 51);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncident";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Incident Form";
            this.Load += new System.EventHandler(this.AddIncident_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVictimImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurpritImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Upload upload1;
        private Wisej.Web.PictureBox pbVictimImage;
        private Wisej.Web.TextBox txtVictimName;
        private Wisej.Web.TextBox txtVictimAge;
        private Wisej.Web.Panel panel6;
        private Wisej.Web.ComboBox cbVictimGender;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel5;
        private Wisej.Web.DateTimePicker dtpCrimeDate;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.ComboBox cbCrimeCategory;
        private Wisej.Web.TextBox txtCrimeLocation;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.TextBox txtCurpritAddress;
        private Wisej.Web.Panel panel7;
        private Wisej.Web.ComboBox cbCurpritGender;
        private Wisej.Web.TextBox txtCurpritAge;
        private Wisej.Web.TextBox txtCurpritName;
        private Wisej.Web.Upload upload2;
        private Wisej.Web.PictureBox pbCurpritImage;
        private Wisej.Web.Button btnSave;
        private Wisej.Web.Button btnReset;
    }
}