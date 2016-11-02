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
    public partial class soanDeThi : UserControl
    {
        public soanDeThi()
        {
            InitializeComponent();


            this.btnXuat.Image = global::AnToanGiaoThong.Properties.Resources.document_arrow_right_icon;
            this.button2.Image=global::AnToanGiaoThong.Properties.Resources.Close_2_icon;
            this.btnHuyDeThi.Image=global::AnToanGiaoThong.Properties.Resources.File_Delete_icon;
            this.btnAdd.Image=global::AnToanGiaoThong.Properties.Resources.add_icon__1_;
            this.btnXuatPDF.Image=global::AnToanGiaoThong.Properties.Resources.pdf_icon__1_;
            this.button3.Image = global::AnToanGiaoThong.Properties.Resources.folder_printer_icon;
        }
    }
}
