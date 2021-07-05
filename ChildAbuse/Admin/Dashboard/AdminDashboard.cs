using ChildAbuse.Data;
using ChildAbuse.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace ChildAbuse.Admin.Dashboard
{
    public partial class AdminDashboard : Form
    {
        ApplicationDbContext _context;

        public AdminDashboard()
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
            var incidents = incidentList.Select((i) =>
                 new IncidentDisplay
                 {
                     Id = i.Id,
                     Category = i.Category,
                     CrimeLocation = i.CrimeLocation,
                     CrimeDescription = i.CrimeDescription,
                     Date = i.Date.Value.ToString("ddd dd MMM, yyyy"),
                     VictimName = i.Victim.VictimName,
                     VictimGender = i.Victim.VictimGender,
                     VictimAge = int.Parse(i.Victim.VictimAge.ToString()),
                     CurpritName = i.Curprit.CurpritName,
                     CurpritGender = i.Curprit.CurpritGender,
                     CurpritAge = i.Curprit.CurpritAge,
                     CurpritAddress = i.Curprit.CurpritAddress
                 }).ToList();

            dataGridView1.DataSource = incidents;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CrimeDescription"].MaximumWidth = 250;
            dataGridView1.Columns["CrimeDescription"].AutoEllipsis = true;

            deleteImages(incidentList);
        }

        public void LoadWhistleBlower()
        {
            _context = new ApplicationDbContext();
            var blowerList = _context.WhistleBlowers.OrderByDescending((i) => i.BlowDate).ToList();
            var blowers = blowerList.Select((i) =>
                 new WhistleBlowerString
                 {
                     Id = i.Id,
                     WhatHappend = i.What,
                     When = i.When,
                     Where = i.Where,
                     WhoInvolved = i.Who,
                     WhistleBlowerContact = i.Contact,
                     SubmittedOn = i.BlowDate.ToString("ddd dd MMM, yyyy")
                 }).ToList();

            dataGridView2.DataSource = blowers;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["WhatHappend"].HeaderText = "What Happend";
            dataGridView2.Columns["WhatHappend"].MaximumWidth = 350;
            dataGridView2.Columns["WhatHappend"].AutoEllipsis = true;
            dataGridView2.Columns["When"].MaximumWidth = 350;
            dataGridView2.Columns["When"].AutoEllipsis = true;
            dataGridView2.Columns["WhoInvolved"].HeaderText = "Who Involved";
            dataGridView2.Columns["WhoInvolved"].MaximumWidth = 350;
            dataGridView2.Columns["WhoInvolved"].AutoEllipsis = true;
            dataGridView2.Columns["Where"].MaximumWidth = 350;
            dataGridView2.Columns["Where"].AutoEllipsis = true;
            dataGridView2.Columns["WhistleBlowerContact"].HeaderText = "WhistleBlower Contact";
            dataGridView2.Columns["WhistleBlowerContact"].MaximumWidth = 350;
            dataGridView2.Columns["WhistleBlowerContact"].AutoEllipsis = true;
            dataGridView2.Columns["SubmittedOn"].HeaderText = "Submitted On";

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
               i.Category.StartsWith(search, StringComparison.OrdinalIgnoreCase) ||
               i.Victim.VictimName.StartsWith(search, StringComparison.OrdinalIgnoreCase)).ToList();

            LoadIncidents(incidentList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIncidents();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident(this);
            addIncident.ShowDialog();
            LoadIncidents();
        }

        private void AdminDashboard_Appear(object sender, EventArgs e)
        {
            LoadIncidents();
            LoadWhistleBlower();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = Guid.Parse(dataGridView1.CurrentRow[0].Value.ToString());
            var currentIncident = _context.Incidents.SingleOrDefault((i) => i.Id == index);
            if (currentIncident != null)
            {
                DialogResult dialogResult;
                ActionDialog popup = new ActionDialog();
                dialogResult = popup.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    AddIncident control = new AddIncident(this, currentIncident);
                    control.ShowDialog();
                }
                else if (dialogResult == DialogResult.Abort)
                {
                    var actionResult =
                       MessageBox.Show("Remove book's record", "Delete",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (actionResult == DialogResult.OK)
                    {

                        try
                        {
                            var victim = _context.Victims.SingleOrDefault((v) => v.Id == currentIncident.Victim.Id);
                            _context.Victims.Remove(victim);
                            _context.SaveChanges();

                            var curprit = _context.Curprits.SingleOrDefault((c) => c.Id == currentIncident.Curprit.Id);
                            _context.Curprits.Remove(curprit);
                            _context.SaveChanges();

                            _context.Incidents.Remove(currentIncident);
                            _context.SaveChanges();
                            MessageBox.Show("Book's record deleted");

                        }
                        catch
                        {
                            MessageBox.Show("Cannot delete, a user is currently accessing the information");
                        }
                    }

                }
                LoadIncidents();
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = Guid.Parse(dataGridView2.CurrentRow[0].Value.ToString());
            var currentBlower = _context.WhistleBlowers.SingleOrDefault((i) => i.Id == index);
            if (currentBlower != null)
            {
                WhistleDetails details = new WhistleDetails(currentBlower);
                details.ShowDialog();
            }
        }

        private void deleteImages(List<Incident> incidents)
        {
            var path = $"{Application.MapPath("./")}/uploads/";
            string[] allImages = Directory.GetFiles(path, "*.png");
            List<string> newList = new List<string>();
            Array.ForEach(allImages, (a) =>
            {
                var img = Path.GetFileNameWithoutExtension(a);
                incidents.ForEach((i) =>
                {
                    if (i.Victim.Id.ToString() == img || i.Curprit.Id.ToString() == img)
                    {
                        newList.Add(img);
                    }
                });
            });
            var toDelete = allImages.Where((a) => !newList.Contains(Path.GetFileNameWithoutExtension(a))).ToList();
            try
            {
                toDelete.ForEach((img) =>
                {
                    if (File.Exists(img))
                    {
                        File.Delete(img);
                    }
                });
            }
            catch { }
        }

        private void btnUser_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
            if (e.Item.Name == "menuLogout")
            {
                Application.Browser.LocalStorage.RemoveValue("child_abuse_admin");
                Application.Navigate("/Admin");
            }
        }
    }
}
