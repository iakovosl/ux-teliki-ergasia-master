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
    public partial class DashboardForm : Form
    {
        Form loginForm;
        Form closetForm;
        Form fridgeForm;
        Form roomsForm;
        User currentUser;

        public DashboardForm()
        {
            InitializeComponent();
            exitToolTip.SetToolTip(exitPictureBox, "Έξοδος από την εφαρμογή");
            closetToolTip.SetToolTip(closetPictureBox, "Έξυπνη Ντουλάπα");
            fridgeToolTip.SetToolTip(pictureBox2, "Έξυπνo Ψυγείο");
            roomsToolTip.SetToolTip(pictureBox1, "Διαχείριση Φωτισμού");

            infoToolTip.SetToolTip(infoPictureBox, "Περισσότερες πληροφορίες");
            loginLogoutTooltTip.SetToolTip(loginPictureBox, "Σύνδεση/Αποσύνδεση");
            loginForm = new LoginForm(dashboardForm: this);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SmartHome.chm", HelpNavigator.TopicId, "4");
        }

        private void loginPictureBox_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm(this);
            loginForm.Show();
            loginForm.Closed += (s, args) => this.Show();
            loginForm.Closed += (s, args) => this.Enabled = true;
            this.Enabled = false;
        }

        public void LoginUser(User user)
        {
            this.currentUser = user;
            currentUserValueLabel.Text = currentUser.username;
            loginPictureBox.Image = Properties.Resources._002_unlock;
        }

        private void closetPictureBox_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                closetForm = new ClosetForm(this, currentUser);
                closetForm.Show();
                closetForm.Closed += (s, args) => this.Show();
                closetForm.Closed += (s, args) => this.Enabled = true;
                this.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                fridgeForm = new FridgeForm(this, currentUser);
                fridgeForm.Show();
                fridgeForm.Closed += (s, args) => this.Show();
                fridgeForm.Closed += (s, args) => this.Enabled = true;
                this.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                roomsForm = new RoomsForm(this, currentUser);
                roomsForm.Show();
                roomsForm.Closed += (s, args) => this.Show();
                roomsForm.Closed += (s, args) => this.Enabled = true;
                this.Enabled = false;
            }
            
        }
    }
}
