using ChildAbuse.Data;
using ChildAbuse.Model;
using System;
using Wisej.Web;

namespace ChildAbuse.Components
{
    public partial class WhistleBlowerForm : Form
    {
        ApplicationDbContext _context;

        public WhistleBlowerForm()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtWhat.Text == "")
            {
                ShowMessage(txtWhat);
                return;
            }
            if (txtWhen.Text == "")
            {
                ShowMessage(txtWhen);
                return;
            }
            if (txtWhere.Text == "")
            {
                ShowMessage(txtWhere);
                return;
            }
            if (txtWho.Text == "")
            {
                ShowMessage(txtWho);
                return;
            }

            AddRecord();
            this.Dispose();
        }

        private void AddRecord()
        {
            try
            {
                WhistleBlower blower = new WhistleBlower
                {
                    What = txtWhat.Text,
                    When = txtWhen.Text,
                    Where = txtWhere.Text,
                    Who = txtWho.Text,
                    Contact = txtContact.Text
                };
                _context.WhistleBlowers.Add(blower);
                _context.SaveChanges();
                MessageBox.Show("Record send, Thank you");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMessage(TextBox box)
        {
            MessageBox.Show("Field required");
            box.Focus();
        }
    }
}
