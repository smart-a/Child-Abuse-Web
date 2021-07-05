using ChildAbuse.Model;
using System;
using Wisej.Web;

namespace ChildAbuse.Admin.Dashboard
{
    public partial class WhistleDetails : Form
    {
        WhistleBlower _blower;

        public WhistleDetails(WhistleBlower blower)
        {
            InitializeComponent();
            _blower = blower;
        }

        private void WhistleDetails_Load(object sender, EventArgs e)
        {
            var contact = _blower.Contact == "" ? "No contact details" : _blower.Contact;
            lblWhistle.Text = $"<b>Date:</b><br/>{_blower.BlowDate.ToString("dddd dd MMMM, yyyy")}" +
                $"<br/><br/><b>What happened?</b><br/>{_blower.What}" +
                $"<br/><br/><b>When did it happen?</b><br/>{_blower.When}" +
                $"<br/><br/><b>Where did it happen?</b><br/>{_blower.Where}" +
                $"<br/><br/><b>Who are the relevant persons and/or entities involved?</b><br/>{_blower.Who}" +
                $"<br/><br/><b>Whistleblower contact details:</b><br/>{contact}"; 
        }
    }
}
