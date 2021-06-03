using System;
using Wisej.Web;
using ChildAbuse.Data;
using ChildAbuse.Model;
using System.Drawing;
using System.Drawing.Imaging;

namespace ChildAbuse.Admin.Dashboard
{
    public partial class AddIncident : Form
    {
        ApplicationDbContext _context;

        public AddIncident()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {
            string[] crimeCategory = { "Physical Abuse", "Sexual Abuse", "Emotional Abuse",
                "Bullying & Cyberbullying", "Child Neglect", "Grooming", "Other Abuse" };

            cbCrimeCategory.DataSource = crimeCategory;
            cbCrimeCategory.Text = "";

            dtpCrimeDate.Value = DateTime.Now;

            string[] gender = { "Male", "Female" };
            cbCurpritGender.DataSource = gender;
            cbVictimGender.DataSource = gender;
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            if (e.Files[0].ContentType.IndexOf("/jpg") < 0 || e.Files[0].ContentType.IndexOf("/png") < 0)
            {
                MessageBox.Show("Invalid file, please select JPG or PNG file");
                return;
            }
            pbVictimImage.ImageSource = e.Files[0].FileName;
        }

        private void upload2_Uploaded(object sender, UploadedEventArgs e)
        {
            if (e.Files[0].ContentType.IndexOf("/jpg") < 0 || e.Files[0].ContentType.IndexOf("/png") < 0)
            {
                MessageBox.Show("Invalid file, please select JPG or PNG file");
                return;
            }
            pbCurpritImage.ImageSource = e.Files[0].FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("Some fields are required");
                return;
            }

            try
            {
                var victim = new Victim
                {
                    VictimName = txtVictimName.Text,
                    VictimGender = cbVictimGender.Text,
                    VictimAge = int.Parse(txtVictimAge.Text)
                };
                _context.Victims.Add(victim);
                _context.SaveChanges();
                UploadImage(victim.Id.ToString(), pbVictimImage.Image);

                var curprit = new Curprit
                {
                    CurpritName = txtCurpritName.Text,
                    CurpritGender = cbCurpritGender.Text,
                    CurpritAge = int.Parse(txtCurpritAge.Text),
                    CurpritAddress = txtCurpritAddress.Text
                };
                _context.Curprits.Add(curprit);
                _context.SaveChanges();
                UploadImage(curprit.Id.ToString(), pbCurpritImage.Image);

                var incident = new Incident
                {
                    Category = cbCrimeCategory.Text,
                    Date = dtpCrimeDate.Value,
                    CrimeLocation = txtCrimeLocation.Text,
                    Victim = victim,
                    Curprit = curprit
                };
                _context.Incidents.Add(incident);
                _context.SaveChanges();

                MessageBox.Show("New record added");
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UploadImage(string name, Image image)
        {
            var appPath = Application.MapPath("./");
            string imagePath = $"{appPath}/uploads";

            bool exists = System.IO.Directory.Exists(imagePath);
            if (!exists)
                System.IO.Directory.CreateDirectory(imagePath);

            image.Save($"{imagePath}/{name}", ImageFormat.Png);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            cbCrimeCategory.Text = "";
            txtCrimeLocation.Text = "";
            txtVictimName.Text = "";
            cbVictimGender.Text = "";
            txtVictimAge.Text = "";
            txtCurpritName.Text = "";
            cbCurpritGender.Text = "";
            txtCurpritAge.Text = "";
            txtCurpritAddress.Text = "";

            pbVictimImage.Image = null;
            upload1.Value = "";
            pbCurpritImage.Image = null;
            upload1.Value = "";

            cbCrimeCategory.Focus();

        }

        private bool IsValidInput()
        {
            if (cbCrimeCategory.Text == "")
            {
                cbCrimeCategory.Focus();
                return false;
            }
            if (txtCrimeLocation.Text == "")
            {
                txtCrimeLocation.Focus();
                return false;
            }
            if (txtVictimName.Text == "")
            {
                txtVictimName.Focus();
                return false;
            }
            if (cbVictimGender.Text == "")
            {
                cbVictimGender.Focus();
                return false;
            }
            if (txtVictimAge.Text == "")
            {
                txtVictimAge.Focus();
                return false;
            }
            if (txtCurpritName.Text == "")
            {
                txtCurpritName.Focus();
                return false;
            }
            if (cbCurpritGender.Text == "")
            {
                cbCurpritGender.Focus();
                return false;
            }
            if (txtCurpritAge.Text == "")
            {
                txtCurpritAge.Focus();
                return false;
            }
            if (txtCurpritAddress.Text == "")
            {
                txtCurpritAddress.Focus();
                return false;
            }

            return true;
        }
    }
}
