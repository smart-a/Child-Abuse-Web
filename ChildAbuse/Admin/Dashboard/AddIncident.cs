using System;
using Wisej.Web;
using ChildAbuse.Data;
using ChildAbuse.Model;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;
using System.IO;

namespace ChildAbuse.Admin.Dashboard
{
    public partial class AddIncident : Form
    {
        ApplicationDbContext _context;
        Incident _incident;
        object _Owner;

        public AddIncident(object Owner = null, Incident incident = null)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _incident = incident;
            _Owner = Owner;

            this.Height = 650;
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

            if (_incident != null)
            {
                cbCrimeCategory.Text = _incident.Category;
                txtDescription.Text = _incident.CrimeDescription;
                dtpCrimeDate.Value = _incident.Date.Value;
                txtCrimeLocation.Text = _incident.CrimeLocation;
                txtVictimName.Text = _incident.Victim.VictimName;
                txtVictimAge.Text = _incident.Victim.VictimAge.ToString();
                cbVictimGender.Text = _incident.Victim.VictimGender;
                txtCurpritName.Text = _incident.Curprit.CurpritName;
                txtCurpritAge.Text = _incident.Curprit.CurpritAge.ToString();
                cbCurpritGender.Text = _incident.Curprit.CurpritGender;
                txtCurpritAddress.Text = _incident.Curprit.CurpritAddress;

                btnSave.Text = "Update Record";
                this.Text = $"Update {this.Text}";

                var appPath = Application.MapPath("./");
                var path = $"{appPath}/uploads/{_incident.Victim.Id}.png";
                if (File.Exists(path))
                {
                    pbVictimImage.Image = Image.FromFile(path);
                }
                path = $"{appPath}/uploads/{_incident.Curprit.Id}.png";
                if (File.Exists(path))
                {
                    pbCurpritImage.Image = Image.FromFile(path);
                }
            }
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
            if (pbVictimImage.Image != null)
            {
                pbVictimImage.Image.Dispose();
            }
            SetImage(e.Files, pbVictimImage);
        }

        private void upload2_Uploaded(object sender, UploadedEventArgs e)
        {
            if (pbCurpritImage.Image != null)
            {
                pbCurpritImage.Image.Dispose();
            }
            SetImage(e.Files, pbCurpritImage);
        }

        private void SetImage(HttpFileCollection Files, PictureBox pictureBox)
        {
            if (Files == null)
            {
                MessageBox.Show("Please select a file");
                return;
            }

            try
            {
                if (Files[0].ContentType.IndexOf("/jpg") < 0 &&
                    Files[0].ContentType.IndexOf("/jpeg") < 0 &&
                    Files[0].ContentType.IndexOf("/png") < 0)
                {
                    MessageBox.Show("Invalid file, please select JPG or PNG file");
                    return;
                }

                pictureBox.Image = Image.FromStream(Files[0].InputStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                if (_incident != null)
                {
                    var victim = new Victim
                    {
                        Id = _incident.Victim.Id,
                        VictimName = txtVictimName.Text,
                        VictimGender = cbVictimGender.Text,
                        VictimAge = int.Parse(txtVictimAge.Text)
                    };
                    _context.Entry(victim).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                    if (upload1.Value != "")
                    {
                        DeleteUploads(victim.Id.ToString());
                        UploadImage(victim.Id.ToString(), pbVictimImage.Image);
                    }

                    var curprit = new Curprit
                    {
                        Id = _incident.Curprit.Id,
                        CurpritName = txtCurpritName.Text,
                        CurpritGender = cbCurpritGender.Text,
                        CurpritAge = int.Parse(txtCurpritAge.Text),
                        CurpritAddress = txtCurpritAddress.Text
                    };
                    _context.Entry(curprit).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                    if (upload2.Value != "")
                    {
                        DeleteUploads(curprit.Id.ToString());
                        UploadImage(curprit.Id.ToString(), pbCurpritImage.Image);
                    }

                    var incident = new Incident
                    {
                        Id = _incident.Id,
                        Category = cbCrimeCategory.Text,
                        Date = dtpCrimeDate.Value,
                        CrimeLocation = txtCrimeLocation.Text,
                        CrimeDescription = txtDescription.Text,
                        Victim = victim,
                        Curprit = curprit
                    };

                    _context.Entry(incident).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                    var parent = (AdminDashboard)_Owner;
                    parent.LoadIncidents();

                    MessageBox.Show("Incident record updated");
                    this.Close();
                }
                else
                {
                    var victim = new Victim
                    {
                        VictimName = txtVictimName.Text,
                        VictimGender = cbVictimGender.Text,
                        VictimAge = int.Parse(txtVictimAge.Text)
                    };
                    _context.Victims.Add(victim);
                    _context.SaveChanges();

                    if (upload1.Value != "")
                    {
                        UploadImage(victim.Id.ToString(), pbVictimImage.Image);
                    }

                    var curprit = new Curprit
                    {
                        CurpritName = txtCurpritName.Text,
                        CurpritGender = cbCurpritGender.Text,
                        CurpritAge = int.Parse(txtCurpritAge.Text),
                        CurpritAddress = txtCurpritAddress.Text
                    };
                    _context.Curprits.Add(curprit);
                    _context.SaveChanges();

                    if (upload2.Value != "")
                    {
                        UploadImage(curprit.Id.ToString(), pbCurpritImage.Image);
                    }

                    var incident = new Incident
                    {
                        Category = cbCrimeCategory.Text,
                        Date = dtpCrimeDate.Value,
                        CrimeLocation = txtCrimeLocation.Text,
                        CrimeDescription = txtDescription.Text,
                        Victim = victim,
                        Curprit = curprit
                    };
                    _context.Incidents.Add(incident);
                    _context.SaveChanges();

                    MessageBox.Show("New record added");
                    ClearInput();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} - {ex.StackTrace}");
            }
        }

        private void DeleteUploads(string imagePath)
        {
            var appPath = Application.MapPath("./");
            var path = $"{appPath}/uploads/{imagePath}.png";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void UploadImage(string name, Image image)
        {
            var appPath = Application.MapPath("./");
            string imagePath = $"{appPath}/uploads";

            bool exists = System.IO.Directory.Exists(imagePath);
            if (!exists)
                System.IO.Directory.CreateDirectory(imagePath);

            image.Save($"{imagePath}/{name}.png", ImageFormat.Png);
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
            txtDescription.Text = "";

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
            if (txtDescription.Text == "")
            {
                txtDescription.Focus();
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
