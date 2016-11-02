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
    public partial class nganHangCauHoi : UserControl
    {
        public nganHangCauHoi()
        {
           
            InitializeComponent();
            this.btnLuu.Image=global::AnToanGiaoThong.Properties.Resources.Actions_document_save_icon;

            this.btnXoa.Image=AnToanGiaoThong.Properties.Resources.File_Delete_icon;

            this.btnThem.Image=AnToanGiaoThong.Properties.Resources.add_icon__1_;

            this.btnSua.Image=global::AnToanGiaoThong.Properties.Resources.Edit_Document_icon;

            this.btnHuy.Image=global::AnToanGiaoThong.Properties.Resources.Close_2_icon;
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
