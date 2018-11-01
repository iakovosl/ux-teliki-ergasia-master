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
using WeatherNet;
using WeatherNet.Clients;

namespace ux_teliki_ergasia_virvou
{
    public partial class ClosetForm : Form
    {
        DashboardForm dashboardForm;
        User currentUser;
        List<PictureBox> topBoxes = new List<PictureBox>(3);
        List<PictureBox> legBoxes = new List<PictureBox>(3);
        List<PictureBox> shoeBoxes = new List<PictureBox>(3);
        List<int> topIndexRange = new List<int>(2);
        List<int> legIndexRange = new List<int>(2);
        List<int> shoeIndexRange = new List<int>(2);

        public ClosetForm()
        {
            InitializeComponent();
        }

        public ClosetForm(DashboardForm parentForm, User currentUser) : this()
        {
            shoeIndexRange.Add(0);
            shoeIndexRange.Add(3);
            legIndexRange.Add(0);
            legIndexRange.Add(3);
            topIndexRange.Add(0);
            topIndexRange.Add(3);

            this.dashboardForm = parentForm;
            this.currentUser = currentUser;
            var list = Shoe.getAllShoes();
            var legList = Leg.getAllLegs();
            var topList = TheTop.getAllTops();

            topBoxes.Add(pictureBox17);
            topBoxes.Add(pictureBox16);
            topBoxes.Add(pictureBox15);

            legBoxes.Add(pictureBox13);
            legBoxes.Add(pictureBox12);
            legBoxes.Add(pictureBox11);

            shoeBoxes.Add(pictureBox4);
            shoeBoxes.Add(pictureBox5);
            shoeBoxes.Add(pictureBox6);


            for (int i = 0; i < shoeBoxes.Count; i++)
            {
                shoeBoxes[i].Image = list[i].image;
            }

            for (int i = 0; i < legBoxes.Count; i++)
            {
                legBoxes[i].Image = legList[i].image;
            }

            for (int i = 0; i < topBoxes.Count; i++)
            {
                topBoxes[i].Image = topList[i].image;
            }

            ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5/";
            ClientSettings.ApiKey = "ae5e6af18a3ccd4e5669281826712bd3";
            try
            {
                var weather = new CurrentWeather();
                var result = weather.GetByCityName("Athens", "Greece");
                weatherLabelText.Text = result.Item.Title;
                var weatherIcon = result.Item.Icon;
                weatherInfoLabel.Text = Convert.ToString(result.Item.Humidity) + "%";
                weatherTempLabel.Text = Convert.ToString(result.Item.Temp - 273.15) + " C";
                var iconPath = Application.StartupPath + "\\weather-icons\\" + weatherIcon + ".png";
                Bitmap bit = new Bitmap(iconPath);
                weatherIconPictureBox.Image = bit;
            } catch(Exception)
            {
                weatherLabelText.Text = "Cloud";
                weatherInfoLabel.Text = "60%";
                var weatherIcon = "10d";
                var iconPath = Application.StartupPath + "\\weather-icons\\" + weatherIcon + ".png";
                Bitmap bit = new Bitmap(iconPath);
                weatherIconPictureBox.Image = bit;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // shoe arrow next
            List<Image> allList = Shoe.getAllImages();

            Console.WriteLine("shoeIndexRange: [" + shoeIndexRange[0] + ", " + shoeIndexRange[1] + "]");
       
            if (shoeIndexRange[1] < allList.Count)
            {
                shoeIndexRange[0] += 1;
                shoeIndexRange[1] += 1;
                List<Image> list = Shoe.getImageRange(shoeIndexRange[0], shoeIndexRange[1]);
                for (int i = 0; i < shoeBoxes.Count; i++)
                {
                    shoeBoxes[i].Image = list[i];
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // shoe arrow left
            List<Image> allList = Shoe.getAllImages();

            Console.WriteLine("shoeIndexRange: [" + shoeIndexRange[0] + ", " + shoeIndexRange[1] + "]");

            if (shoeIndexRange[0] >= 0)
            {
                shoeIndexRange[0] -= 1;
                shoeIndexRange[1] -= 1;
                List<Image> list = Shoe.getImageRange(shoeIndexRange[0], shoeIndexRange[1]);

                for (int i = 0; i < shoeBoxes.Count; i++)
                {
                    shoeBoxes[i].Image = list[i];
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // leg next
            List<Image> allList = Leg.getAllImages();

            Console.WriteLine("legIndexRange: [" + legIndexRange[0] + ", " + legIndexRange[1] + "]");

            if (legIndexRange[1] < allList.Count)
            {
                legIndexRange[0] += 1;
                legIndexRange[1] += 1;
                List<Image> list = Leg.getImageRange(legIndexRange[0], legIndexRange[1]);
                for (int i = 0; i < legBoxes.Count; i++)
                {
                    legBoxes[i].Image = list[i];
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // leg previous
            List<Image> allList = Leg.getAllImages();

            Console.WriteLine("shoeIndexRange: [" + legIndexRange[0] + ", " + legIndexRange[1] + "]");

            if (legIndexRange[0] >= 0)
            {
                legIndexRange[0] -= 1;
                legIndexRange[1] -= 1;
                List<Image> list = Leg.getImageRange(legIndexRange[0], legIndexRange[1]);

                for (int i = 0; i < legBoxes.Count; i++)
                {
                    legBoxes[i].Image = list[i];
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // top next
            List<Image> allList = TheTop.getAllImages();

            Console.WriteLine("topIndexRange: [" + topIndexRange[0] + ", " + topIndexRange[1] + "]");

            if (topIndexRange[1] < allList.Count)
            {
                topIndexRange[0] += 1;
                topIndexRange[1] += 1;
                List<Image> list = TheTop.getImageRange(topIndexRange[0], topIndexRange[1]);
                for (int i = 0; i < topBoxes.Count; i++)
                {
                    topBoxes[i].Image = list[i];
                }
            }
        }
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // top previous
            List<Image> allList = TheTop.getAllImages();

            Console.WriteLine("shoeIndexRange: [" + topIndexRange[0] + ", " + topIndexRange[1] + "]");

            if (topIndexRange[0] >= 0)
            {
                topIndexRange[0] -= 1;
                topIndexRange[1] -= 1;
                List<Image> list = TheTop.getImageRange(topIndexRange[0], topIndexRange[1]);

                for (int i = 0; i < topBoxes.Count; i++)
                {
                    topBoxes[i].Image = list[i];
                }
            }
        }
    }
}
