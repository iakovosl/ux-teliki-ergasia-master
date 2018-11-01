using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ux_teliki_ergasia_virvou
{
    public partial class LoginForm : Form
    {
        DashboardForm dashboardForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(DashboardForm dashboardForm) : this()
        {
            this.dashboardForm = dashboardForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            User user;

            if ((user = User.checkUser(username, password)) != null)
            {
                this.Close();
                dashboardForm.LoginUser(user);
                dashboardForm.Enabled = true;
            }
            else
            {
                Timer validationTimer = new Timer();
                validationTimer.Interval = 3000;
                validationTimer.Tick += ValidationTimer_Tick;
                validationTimer.Start();
                validationLabel.Visible = true;
            }
        }

        private void ValidationTimer_Tick(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
        }
    }
}
