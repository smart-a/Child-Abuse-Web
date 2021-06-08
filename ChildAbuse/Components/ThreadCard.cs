using ChildAbuse.Data;
using ChildAbuse.Model;
using ChildAbuse.Properties;
using System;
using System.Drawing;
using System.IO;
using Wisej.Web;

namespace ChildAbuse.Components
{
    public partial class ThreadCard : Wisej.Web.UserControl
    {
        ApplicationDbContext _context;
        Incident _incident;

        public ThreadCard(Form Owner, Incident incident)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _incident = incident;
            this.Height = 165;
            //this.Width = Owner.Width;
        }

        private void ThreadCard_Load(object sender, EventArgs e)
        {
            lblCrimeCategory.Text = _incident.Category;
            lblCrimeDetails.Text = _incident.CrimeDescription;
            lblVictimName.Text = _incident.Victim.VictimName;
            lblVictimGender.Text = _incident.Victim.VictimGender;
            lblVictimAge.Text = _incident.Victim.VictimAge.ToString();
            lblLocation.Text = _incident.CrimeLocation;
            lblDate.Text = _incident.Date.Value.ToString("ddd dd MMM, yyyy");
            lblCurprit.Text = _incident.Curprit.CurpritName;
            lblCurpritGender.Text = _incident.Curprit.CurpritGender;
            lblCurpritAddress.Text = _incident.Curprit.CurpritAddress;
            lblCurpritAge.Text = _incident.Curprit.CurpritAge.ToString();

            LoadImage(_incident.Victim.Id.ToString(), pbVictimImage);
            LoadImage(_incident.Curprit.Id.ToString(), pbCurpritImage, "curprit");
        }

        private void LoadImage(string path, PictureBox pictureBox, string type = "victim")
        {
            var appPath = Application.MapPath("./");
            string imagePath = $"{appPath}/uploads/{path}.png";
            if (!File.Exists(imagePath))
            {
                if(type == "victim")
                {
                    pictureBox.Image = Resources.Child_abuse;
                }
                else
                {
                    pictureBox.Image = Resources.Curprit;
                }
            }
            else
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }

        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if(this.Height == 525)
            {
                btnReadMore.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/angle-down.svg";
                this.Height = 165;
                btnReadMore.Text = "Read More";
            }
            else
            {
                btnReadMore.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/angle-up.svg";
                this.Height = 525;
                btnReadMore.Text = "Read Less";
            }
        }
    }
}
