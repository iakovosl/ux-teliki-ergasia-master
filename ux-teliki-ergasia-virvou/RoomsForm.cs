using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ux_teliki_ergasia_virvou
{
    public partial class RoomsForm : Form
    {
        DashboardForm dashboard;
        User currentUser;

        public RoomsForm()
        {
            InitializeComponent();
        }

        public RoomsForm(DashboardForm parentForm, User currentUser) : this()
        {
            this.dashboard = parentForm;
            this.currentUser = currentUser;
            pictureBox2.Tag = "on";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Kouzina Lights toggle
            if (pictureBox2.Tag == "on")
            {
                pictureBox2.Image = Properties.Resources.light_bulb_off;
                pictureBox2.Tag = "off";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.light_bulb_on;
                pictureBox2.Tag = "on";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "on")
            {
                pictureBox4.Image = Properties.Resources.light_bulb_off;
                pictureBox4.Tag = "off";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.light_bulb_on;
                pictureBox4.Tag = "on";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag == "on")
            {
                pictureBox3.Image = Properties.Resources.light_bulb_off;
                pictureBox3.Tag = "off";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.light_bulb_on;
                pictureBox3.Tag = "on";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Tag == "on")
            {
                pictureBox8.Image = Properties.Resources.light_bulb_off;
                pictureBox8.Tag = "off";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.light_bulb_on;
                pictureBox8.Tag = "on";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag == "on")
            {
                pictureBox5.Image = Properties.Resources.light_bulb_off;
                pictureBox5.Tag = "off";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.light_bulb_on;
                pictureBox5.Tag = "on";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag == "on")
            {
                pictureBox6.Image = Properties.Resources.light_bulb_off;
                pictureBox6.Tag = "off";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.light_bulb_on;
                pictureBox6.Tag = "on";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag == "on")
            {
                pictureBox7.Image = Properties.Resources.light_bulb_off;
                pictureBox7.Tag = "off";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.light_bulb_on;
                pictureBox7.Tag = "on";
            }
        }
    }
}
