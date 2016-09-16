using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            public readonly string text;
            public readonly int weight;

            public Prize(string text, int weight)
            {
                this.text = text;
                this.weight = weight;
            }
        };
        private string prizeText;
        private List<Prize> prizelist = new List<Prize>();

        /// <summary>
        /// create a default tile using the built in picturebox
        /// </summary>
        /// <param name="location"></param>
        public GameTile(Point location)
        {
            Location = location;
            Enabled = true;
            Size = new Size(45, 45);
            SizeMode = PictureBoxSizeMode.StretchImage;
            prizelist.Add(new Prize("cash",50));
            prizelist.Add(new Prize("trip",10));
            prizelist.Add(new Prize("car", 10));
            prizelist.Add(new Prize("living room", 10));
        }

        //sets a random value
        public void SetRandomValue()
        {
            var Random = new Random();
            value = 100 * Random.Next(10);
            CheckWhammy();
        }

        //set value manually
        public void SetValue(int value)
        {
            this.value = value;
            CheckWhammy();
        }
        
        //set prize randomly
        public void SetPrizeType()
        {
            var totalWeight = prizelist.Sum(prize => prize.weight);
            var randomNumber = _rnd.Next(0, totalWeight);

            foreach (var prize in prizelist)
            {
                if (randomNumber <= prize.weight)
                {
                    prizeText = prize.text;
                    break;
                }

                randomNumber = randomNumber - prize.weight;
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
            isWhammy = value <= 0;
        }

        //return if a prize/whammy/cash
        public bool IsWhammy()
        {
            return isWhammy;
        }

        public string GetPrize()
        {
            return prizeText;
        }

        public int GetValue()
        {
            return value;
        }

        //create a stack of whammy images

        //create a stack of prize images

        //create a stack of jump images
    }
}
