using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ucButtonMenu;
namespace AnToanGiaoThong.Frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            new Classes.MoveFrame(panel6);
            mButtonMenu1.Click+=new EventHandler(btnMenuClick);
            mButtonMenu2.Click+=new EventHandler(btnMenuClick);
            mButtonMenu3.Click+=new EventHandler(btnMenuClick);

            mButtonMenu1.SetImage(AnToanGiaoThong.Properties.Resources.winter_nature_1280x720);
        }
        private void btnMenuClick(object sender, EventArgs e)
        {
            mButtonMenu1.SELECTED=false;
            mButtonMenu2.SELECTED=false;
            mButtonMenu3.SELECTED=false;
            ((mButtonMenu)sender).SELECTED=true;
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
