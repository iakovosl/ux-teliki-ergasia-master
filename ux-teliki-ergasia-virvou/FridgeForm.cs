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
    public partial class FridgeForm : Form
    {
        DashboardForm dashboard;
        User currentUser;

        public FridgeForm()
        {
            InitializeComponent();
        }

        public FridgeForm(DashboardForm parentForm, User currentUser) : this()
        {
            this.dashboard = parentForm;
            this.currentUser = currentUser;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] p = { "omeleta", "xumos", "cafe" };
            string[] m = { "kotopoulo", "fasolakia", "gemista" };
            string[] v = { "makaronia", "pizza", "souvlakia" };

            if (comboBox1.Text == "Πρωινό")
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(p);

            }

            if (comboBox1.Text == "Μεσημεριανό")
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(m);
            }

            if (comboBox1.Text == "Βραδινό")
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(v);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "omeleta")
            {
                pictureBox1.Image = Properties.Resources.img1;
            }
            if (listBox1.Text == "xumos")
            {
                pictureBox1.Image = Properties.Resources.img2;
            }
            if (listBox1.Text == "cafe")
            {
                pictureBox1.Image = Properties.Resources.img3;
            }
            if (listBox1.Text == "kotopoulo")
            {
                pictureBox1.Image = Properties.Resources.img4;
            }
            if (listBox1.Text == "fasolakia")
            {
                pictureBox1.Image = Properties.Resources.img5;
            }
            if (listBox1.Text == "gemista")
            {
                pictureBox1.Image = Properties.Resources.img6;
            }
            if (listBox1.Text == "makaronia")
            {
                pictureBox1.Image = Properties.Resources.img7;
            }
            if (listBox1.Text == "pizza")
            {
                pictureBox1.Image = Properties.Resources.img8;
            }
            if (listBox1.Text == "souvlakia")
            {
                pictureBox1.Image = Properties.Resources.img9;
            }

        }
    }
}
