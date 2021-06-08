using ChildAbuse.Components;
using ChildAbuse.Data;
using ChildAbuse.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace ChildAbuse
{
    public partial class LadingPage : Form
    {
        ApplicationDbContext _context;
        int minX = -515;
        int maxX = 895;

        public LadingPage()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        public void LoadIncidents(List<Incident> param = null)
        {
            var incidentList = param;
            if (incidentList == null || incidentList.Count < 1)
            {
                incidentList = _context.Incidents.OrderByDescending((i) => i.Date).ToList();
            }

            if (incidentList == null || incidentList.Count < 1)
            {
                Label label = new Label
                {
                    Text = "No Content",
                    Dock = DockStyle.Fill,
                    Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel),
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                };
                tableLayoutPanelpost.Controls.Add(label);
                return;
            }

            tableLayoutPanelpost.Controls.Clear();
            int row = 1;
            incidentList.ForEach((incident) =>
            {
                ThreadCard card = new ThreadCard(this, incident);

                card.Anchor = AnchorStyles.None;
                tableLayoutPanelpost.Controls.Add(card,0,row);
                row += 1;
            });
            tableLayoutPanelpost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var search = txtSearch.Text;
            if (search == "")
            {
                LoadIncidents();
                return;
            }
            var incidentList = _context.Incidents.OrderByDescending((i) => i.Date).ToList();
            incidentList = incidentList.Where((i) =>
               i.Category.Contains(search) ||
               i.Victim.VictimName.Contains(search)).ToList();

            LoadIncidents(incidentList);
        }

        private void LadingPage_Appear(object sender, EventArgs e)
        {
            maxX = this.Width;
            lblMarquee.Left = maxX;
            timer1.Start();
            LoadIncidents();

            var path = $"{Application.MapPath("./")}/uploads/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblMarquee.Location.X <= maxX)
            {
                lblMarquee.Left -= 1;
            }
            if(lblMarquee.Location.X == minX)
            {
                lblMarquee.Left = maxX;
            }
        }
    }
}
