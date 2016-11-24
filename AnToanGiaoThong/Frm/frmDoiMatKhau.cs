using AnToanGiaoThong.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnToanGiaoThong.Frm
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();

            new MoveFrame(this.panel1);

            this.panel2.Controls.Add(new Module.ucDoiMatKhau());
        }
    }
}
