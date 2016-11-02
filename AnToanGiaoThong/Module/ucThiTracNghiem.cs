using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnToanGiaoThong.Module
{
    public partial class ucThiTracNghiem : UserControl
    {
        public ucThiTracNghiem()
        {
            InitializeComponent();

            panel1.AutoScroll=false;
            panel1.HorizontalScroll.Enabled=false;
            panel1.HorizontalScroll.Visible=false;
            panel1.HorizontalScroll.Maximum=0;
            panel1.AutoScroll=true;

            //  vScrollBar1.Scroll+=(sender, e) => { this.panel1.VerticalScroll.Value=vScrollBar1.Value; };
        }
    }
}
