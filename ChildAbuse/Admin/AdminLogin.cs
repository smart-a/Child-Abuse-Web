using ChildAbuse.Data;
using ChildAbuse.Helper;
using System;
using System.Linq;
using Wisej.Web;

namespace ChildAbuse.Admin
{
    public partial class AdminLogin : Form
    {
        ApplicationDbContext _context;

        public AdminLogin()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void btnMsgClose_Click(object sender, EventArgs e)
        {
            panelMsg.Visible = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                HandleProceed();
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            HandleProceed();
        }

        private void DisplayMsg(string message, bool displayCloseButton = true)
        {
            panelMsg.Visible = true;
            lblMsg.Text = message;
            btnCloseMsg.Visible = displayCloseButton;
        }

        private void HandleProceed()
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }

            var admin = _context.UsersAccounts.SingleOrDefault(
                (u) => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

            if (admin != null)
            {
                try
                {
                    DisplayMsg("Login successful, redirecting to dashboard", false);
                    var token = JwtToken.GenerateToken(admin);
                    Application.Browser.LocalStorage.SetValue("child_abuse_admin", token);
                    Application.Navigate("Admin/Dashboard");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DisplayMsg("Account not found");
            }
        }
    }
}
