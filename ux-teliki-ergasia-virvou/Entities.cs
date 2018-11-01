using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ux_teliki_ergasia_virvou
{
    public class User
    {
        static string theUsername = "telis";
        static string thePassword = "123456";
        static string theEmail = "telischristou@gmail.com";

        public string username { get; set; }
        string password { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string email { get; set; }

        public User(string username, string password, string firstName, string lastName, string email)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public static User checkUser(string username, string password)
        {
            User user = null;

            if (username == theUsername && password == thePassword)
            {
                user = new User(username, password, "", "", theEmail);
            }

            return user;
        }
    } // End User


    public class Shoe
    {
        public enum ShoeType
        {
            Sport, Casual, Boot, Summer
        }
        string name;
        string brand;
        string size;
        Color color;
        ShoeType type;
        public Image image;

        public Shoe(string name, string brand, string size, Color color, ShoeType type, Image image)
        {
            this.brand = brand;
            this.size = size;
            this.color = color;
            this.type = type;
            this.image = image;
        }

        public static List<Shoe> getAllShoes()
        {
            List<Shoe> shoeList = new List<Shoe>();
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.White, ShoeType.Casual, Properties.Resources.all_star_black ));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.all_star_blue));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.White, ShoeType.Casual, Properties.Resources.athletic));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.boots));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.White, ShoeType.Casual, Properties.Resources.boots_black));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.formal_black));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.White, ShoeType.Casual, Properties.Resources.formal_black_1));
            shoeList.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.formal_brown));

            return shoeList;
        }

        public static List<Image> getAllImages()
        {
            List<Image> shoeImageList = new List<Image>();

            foreach (var shoe in Shoe.getAllShoes())
            {
                shoeImageList.Add(shoe.image);
            }
            return shoeImageList;
        }

        public static List<Image> getImageRange(int from, int to)
        {
            List<Image> imageRange = new List<Image>(3);
            List<Shoe> allShoes = Shoe.getAllShoes();

            if (from >= 0 && to < allShoes.Count)
            {
                for (int i = from; i < to; i++)
                    imageRange.Add(allShoes[i].image);
            } else if (from >= 0 && to <= allShoes.Count)
            {
                for (int i = from; i < (to -1); i++)
                    imageRange.Add(allShoes[i].image);
                imageRange.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.Empty).image);
            } else if (from + 1 >= 0 && to < allShoes.Count)
            {
                imageRange.Add(new Shoe("All star", "Converse", "44", Color.Black, ShoeType.Casual, Properties.Resources.Empty).image);
                for (int i = from + 1; i < to; i++)
                    imageRange.Add(allShoes[i].image);
            }
            

            return imageRange;
        }

        public override string ToString()
        {
            return name + " " + brand + " " + color;
        }

    } // End Shoe

    public class Leg
    {
        public enum LegType
        {
            Sport, Casual, Boot, Summer
        }
        string name;
        string brand;
        string size;
        Color color;
        LegType type;
        public Image image;

        public Leg(string name, string brand, string size, Color color, LegType type, Image image)
        {
            this.brand = brand;
            this.size = size;
            this.color = color;
            this.type = type;
            this.image = image;
        }

        public static List<Leg> getAllLegs()
        {
            List<Leg> legList = new List<Leg>();
            legList.Add(new Leg("All star", "Converse", "44", Color.White, LegType.Casual, Properties.Resources.all_star_black));
            legList.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.all_star_blue));
            legList.Add(new Leg("All star", "Converse", "44", Color.White, LegType.Casual, Properties.Resources.athletic));
            legList.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.boots));
            legList.Add(new Leg("All star", "Converse", "44", Color.White, LegType.Casual, Properties.Resources.boots_black));
            legList.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.formal_black));
            legList.Add(new Leg("All star", "Converse", "44", Color.White, LegType.Casual, Properties.Resources.formal_black_1));
            legList.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.formal_brown));

            return legList;
        }

        public static List<Image> getAllImages()
        {
            List<Image> imageList = new List<Image>();

            foreach (var shoe in Leg.getAllLegs())
            {
                imageList.Add(shoe.image);
            }
            return imageList;
        }

        public static List<Image> getImageRange(int from, int to)
        {
            List<Image> imageRange = new List<Image>(3);
            List<Leg> allLegs = Leg.getAllLegs();

            if (from >= 0 && to < allLegs.Count)
            {
                for (int i = from; i < to; i++)
                    imageRange.Add(allLegs[i].image);
            }
            else if (from >= 0 && to <= allLegs.Count)
            {
                for (int i = from; i < (to - 1); i++)
                    imageRange.Add(allLegs[i].image);
                imageRange.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.Empty).image);
            }
            else if (from + 1 >= 0 && to < allLegs.Count)
            {
                imageRange.Add(new Leg("All star", "Converse", "44", Color.Black, LegType.Casual, Properties.Resources.Empty).image);
                for (int i = from + 1; i < to; i++)
                    imageRange.Add(allLegs[i].image);
            }


            return imageRange;
        }

        public override string ToString()
        {
            return name + " " + brand + " " + color;
        }

    } // End Leg

    public class TheTop
    {
        public enum TopType
        {
            Sport, Casual, Boot, Summer
        }
        string name;
        string brand;
        string size;
        Color color;
        TopType type;
        public Image image;

        public TheTop(string name, string brand, string size, Color color, TopType type, Image image)
        {
            this.brand = brand;
            this.size = size;
            this.color = color;
            this.type = type;
            this.image = image;
        }

        public static List<TheTop> getAllTops()
        {
            List<TheTop> topList = new List<TheTop>();
            topList.Add(new TheTop("All star", "Converse", "44", Color.White, TopType.Casual, Properties.Resources.all_star_black));
            topList.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.all_star_blue));
            topList.Add(new TheTop("All star", "Converse", "44", Color.White, TopType.Casual, Properties.Resources.athletic));
            topList.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.boots));
            topList.Add(new TheTop("All star", "Converse", "44", Color.White, TopType.Casual, Properties.Resources.boots_black));
            topList.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.formal_black));
            topList.Add(new TheTop("All star", "Converse", "44", Color.White, TopType.Casual, Properties.Resources.formal_black_1));
            topList.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.formal_brown));

            return topList;
        }

        public static List<Image> getAllImages()
        {
            List<Image> imageList = new List<Image>();

            foreach (var shoe in TheTop.getAllTops())
            {
                imageList.Add(shoe.image);
            }
            return imageList;
        }

        public static List<Image> getImageRange(int from, int to)
        {
            List<Image> imageRange = new List<Image>(3);
            List<TheTop> allTops = TheTop.getAllTops();

            if (from >= 0 && to < allTops.Count)
            {
                for (int i = from; i < to; i++)
                    imageRange.Add(allTops[i].image);
            }
            else if (from >= 0 && to <= allTops.Count)
            {
                for (int i = from; i < (to - 1); i++)
                    imageRange.Add(allTops[i].image);
                imageRange.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.Empty).image);
            }
            else if (from + 1 >= 0 && to < allTops.Count)
            {
                imageRange.Add(new TheTop("All star", "Converse", "44", Color.Black, TopType.Casual, Properties.Resources.Empty).image);
                for (int i = from + 1; i < to; i++)
                    imageRange.Add(allTops[i].image);
            }


            return imageRange;
        }

        public override string ToString()
        {
            return name + " " + brand + " " + color;
        }

    } // End Top
}
