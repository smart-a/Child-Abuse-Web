using ChildAbuse.Data;
using ChildAbuse.Model;
using System;
using System.Collections.Generic;
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
                incidentList = _context.Incidents.ToList();
            }

            var incidents = incidentList.Select((i) =>
                 new IncidentDisplay
                 {
                     Id = i.Id,
                     Category = i.Category,
                     CrimeLocation = i.CrimeLocation,
                     Date = i.Date,
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
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var search = txtSearch.Text;
            if (search == "")
            {
                LoadIncidents();
                return;
            }
            var incidentList = _context.Incidents.ToList();
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
            AddIncident addIncident = new AddIncident();
            addIncident.ShowDialog();
            LoadIncidents();
        }
    }
}
