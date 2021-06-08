using ChildAbuse.Admin;
using ChildAbuse.Admin.Dashboard;
using ChildAbuse.Helper;
using System;
using Wisej.Web;

namespace ChildAbuse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            LadingPage window = new LadingPage();
            window.Show();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

        static void Admin()
        {
            Application.Browser.LocalStorage.GetValue("child_abuse_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        Application.Navigate("/Admin/Dashboard");
                        return;
                    }
                }
            });
            AdminLogin window = new AdminLogin();
            window.Show();
        }

        static void AdminDashboard()
        {
            Application.Browser.LocalStorage.GetValue("child_abuse_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        AdminDashboard window = new AdminDashboard();
                        window.Show();
                        return;
                    }
                }
                Application.Navigate("/Admin");
            });
        }
    }
}