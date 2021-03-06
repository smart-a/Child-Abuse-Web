
namespace ChildAbuse.Admin.Dashboard
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle9 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle10 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle11 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle12 = new Wisej.Web.DataGridViewCellStyle();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.btnUser = new Wisej.Web.Button();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuLogout = new Wisej.Web.MenuItem();
            this.label2 = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.btnRefresh = new Wisej.Web.Button();
            this.txtSearch = new Wisej.Web.TextBox();
            this.btnAddNew = new Wisej.Web.Button();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.CssStyle = "box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;";
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 81);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.FromName("@buttonText");
            this.btnUser.BorderStyle = Wisej.Web.BorderStyle.None;
            this.btnUser.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.btnUser.Location = new System.Drawing.Point(731, 19);
            this.btnUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuLogout});
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new Wisej.Web.Padding(8);
            this.btnUser.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnUser.ResponsiveProfiles"))));
            this.btnUser.Size = new System.Drawing.Size(45, 39);
            this.btnUser.TabIndex = 10;
            this.btnUser.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnUser.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.btnUser_ItemClicked);
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.IconSource = "resource.wx/Wisej.Ext.FontAwesome/user-secret.svg";
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "Administrator";
            // 
            // menuLogout
            // 
            this.menuLogout.IconSource = "resource.wx/Wisej.Ext.FontAwesome/reply.svg";
            this.menuLogout.Index = 1;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Text = "Logout";
            // 
            // label2
            // 
            this.label2.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHILD ABUSE PORTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 617);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.btnRefresh.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnRefresh.Location = new System.Drawing.Point(293, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 30);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(27, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new Wisej.Web.Padding(5);
            this.txtSearch.Size = new System.Drawing.Size(260, 30);
            this.txtSearch.TabIndex = 14;
            componentTool2.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/search.svg";
            this.txtSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txtSearch.Watermark = "Incident category or Victim name";
            this.txtSearch.KeyPress += new Wisej.Web.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.Green;
            this.btnAddNew.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddNew.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/plus.svg";
            this.btnAddNew.Location = new System.Drawing.Point(630, 14);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnAddNew.ResponsiveProfiles"))));
            this.btnAddNew.Size = new System.Drawing.Size(110, 35);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(28, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView1.ResponsiveProfiles"))));
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(712, 428);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(771, 567);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnAddNew);
            this.tabPage1.Location = new System.Drawing.Point(1, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(769, 531);
            this.tabPage1.Text = "Incident";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(1, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(769, 531);
            this.tabPage2.Text = "WhistleBlower";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = Wisej.Web.AnchorStyles.Top;
            this.dataGridView2.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            dataGridViewCellStyle10.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.Location = new System.Drawing.Point(29, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataGridView2.ResponsiveProfiles"))));
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(44, 84, 77);
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Size = new System.Drawing.Size(712, 428);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.RowHeaderMouseClick += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildAbuse.Properties.Resources.nigeria_police_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 68);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Appear += new System.EventHandler(this.AdminDashboard_Appear);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Label label2;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Button btnUser;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuLogout;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Button btnRefresh;
        private Wisej.Web.TextBox txtSearch;
        private Wisej.Web.Button btnAddNew;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.TabPage tabPage2;
        private Wisej.Web.DataGridView dataGridView2;
    }
}