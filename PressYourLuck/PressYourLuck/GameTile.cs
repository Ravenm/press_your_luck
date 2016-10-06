using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressYourLuck
{
    /// <summary>
    /// class overwrites the picturebox class to allow us to set up defaults and special methods
    /// </summary>
    internal class GameTile : PictureBox
    {
        private bool isWhammy;
        private int value;
        private Random _rnd = new Random();
        // add value and stuff here so it can be wieghted.
        private struct Prize
        {
            public readonly string Text;
            public readonly int Weight;
            public readonly int Value;
            public readonly string Picture;

            public Prize(string text, int weight, int value, string picture)
            {
                Text = text;
                Weight = weight;
                Picture = picture;
                Value = value;
            }
        };

        private Prize tilePrize;
        private List<Prize> prizelist = new List<Prize>();

        /// <summary>
        /// create a default tile using the built in picturebox
        /// </summary>
        /// <param name="location"></param>
        public GameTile(Point location)
        {
            Location = location;
            Enabled = true;
            Size = new Size(120, 120);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SetPrizeList();
            ImageLocation = tilePrize.Picture;
        }
        
        //set prize randomly
        public void SetPrizeType()
        {
            var totalWeight = prizelist.Sum(a => a.Weight);
            var randomNumber = _rnd.Next(0, totalWeight);

            foreach (var prize in prizelist)
            {
                if (randomNumber <= prize.Weight)
                {
                    tilePrize = prize;
                    break;
                }

                randomNumber = randomNumber - prize.Weight;
            }
        }

        //set whammy manually
        public void SetWhammy(bool whammy = true)
        {
            isWhammy = whammy;
        }

        public void SetWhammy(int whammy = 0)
        {
            isWhammy = whammy != 0;
        }

        //check if value should whammy
        private void CheckWhammy()
        {
            isWhammy = tilePrize.Value <= 0;
        }

        //return if a prize/whammy/cash
        public bool IsWhammy()
        {
            CheckWhammy();
            return isWhammy;
        }

        public string GetPrizeText()
        {
            return tilePrize.Text;
        }

        public int GetValue()
        {
            return tilePrize.Value;
        }

        /// <summary>
        /// currently only one picture
        /// </summary>
        private void SetPrizeList()
        {
            //for (var i = 0; i < 20; i++)
            //{
            //    var cash = i * 100;
            //    var text = Convert.ToString(cash);
            //    prizelist.Add(new Prize(text, 50, cash, (text + ".jpg")));
            //}
            //prizelist.Add(new Prize("Trip to Mars", 10, 20000, "Mars.jpg"));
            //prizelist.Add(new Prize("Trip to Canada", 10, 20000, "Mars.jpg"));
            //prizelist.Add(new Prize("Trip to West part of town", 10, 20, "Town.jpg"));
            //prizelist.Add(new Prize("Trip to CVS", 10, 14, "Mars.jpg"));
            //for (var i = 0; i < 5; i++)
            //{
            //    prizelist.Add(new Prize("Whammy", 10, 0, "Whammy"+i+".jpg"));
            //}

            prizelist.Add(new Prize("Trip to Mars", 10, 20000, "images\\mayorWhammy.png"));
            prizelist.Add(new Prize("Trip to Canada", 10, 20000, "images\\mayorWhammy.png"));
            prizelist.Add(new Prize("Trip to West part of town", 10, 20, "images\\mayorWhammy.png"));
            prizelist.Add(new Prize("Trip to CVS", 10, 14, "images\\mayorWhammy.png"));
            for (var i = 0; i < 5; i++)
            {
                prizelist.Add(new Prize("Whammy", 10, 0, "images\\mayorWhammy.png"));
            }

            SetPrizeType();
        }

    }
}
