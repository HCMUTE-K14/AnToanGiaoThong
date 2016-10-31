using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ucButtonMenu
{
   
    public partial class mButtonMenu : UserControl
    {
        public mButtonMenu()
        {
            InitializeComponent();
        }
        public bool Selected;
     
        public bool SELECTED
        {
            get { return Selected; }
            set { Selected=value; }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode=CompositingMode.SourceCopy;
                graphics.CompositingQuality=CompositingQuality.HighQuality;
                graphics.InterpolationMode=InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode=SmoothingMode.HighQuality;
                graphics.PixelOffsetMode=PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public void SetImage(Image img)
        {
            img=ResizeImage(img, pictureBox1.Size.Width, pictureBox1.Size.Height);
            this.pictureBox1.Image=img;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void mButtonMenu_MouseHover(object sender, EventArgs e)
        {
            if(this.SELECTED==false)
                 this.BackColor=Color.FromArgb(57, 72, 91);
        }

        private void mButtonMenu_MouseLeave(object sender, EventArgs e)
        {
            if(this.SELECTED==false)
                this.BackColor=Color.FromArgb(27, 42, 61);
        }

        private void mButtonMenu_Click(object sender, EventArgs e)
        {
            if (this.SELECTED==true)
            {
                this.BackColor=Color.FromArgb(82, 164, 228);
            }
        }
    }
}
