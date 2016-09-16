using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressYourLuck
{
    public partial class PressYourLuckForm : Form
    {
        private PictureBox[] tileArray;
        private Point[] tileLocations;

        public PressYourLuckForm()
        {
            InitializeComponent();
            tileArray = new PictureBox[8];
        }

        public ICollection<PictureBox> TileArray => tileArray;

        private void GameStart_Click(object sender, EventArgs e)
        {
            // set on offset to skip center square only needed here for xy location
            var offset = 0;
            //loop 3 rows 3 colomns
            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //calculate the actual array index 
                    var index = (i*3) + j;
                    if (index == 4)
                    {
                        offset = 1;
                        continue;
                    }
                    // create the new picturebox at index location ie tileArray[2]
                    tileArray[index - offset] = new PictureBox { Location = new Point(j * 50, i * 50), Enabled = true,
                        Size = new Size(45, 45), SizeMode = PictureBoxSizeMode.StretchImage};
                    //add picturebox to form
                    this.Controls.Add(tileArray[index -offset]);
                    //set an image so it can be seen on board
                    this.tileArray[index - offset].ImageLocation = @"images\mayorWhammy.png";
                }
            }
        }
    }
}
