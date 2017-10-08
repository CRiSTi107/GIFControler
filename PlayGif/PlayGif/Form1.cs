using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayGif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Image gifImage;
        FrameDimension dimension;
        int frameCount;

        private void Form1_Load(object sender, EventArgs e)
        {
            //pic_Gif.Image = Image.FromFile("bg.gif"); = 0 work 4 me

            const string gifPath = "ekko.gif";

            gifImage = Image.FromFile(gifPath);
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            frameCount = gifImage.GetFrameCount(dimension);

            for (int i = 0; i <= frameCount - 1; i++)
                cmb_Index.Items.Add(i);

            base.Size = new Size(gifImage.Size.Width + 40, gifImage.Size.Height + 89);
            base.Text = "GifName='" + gifPath + "' | FrameCount=" + frameCount;
            //base.Text = "GifPath='" + System.IO.Path.GetFullPath(gifPath) + "' | FrameCount=" + frameCount; 
        }

        private void cmb_Index_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFrame = Convert.ToInt32(cmb_Index.SelectedItem);

            gifImage.SelectActiveFrame(dimension, selectedFrame);
            pic_Gif.BackgroundImage = new Bitmap((Image)gifImage.Clone());
        }
    }
}
