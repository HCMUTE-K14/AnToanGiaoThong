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
using ucButtonMenu;
namespace AnToanGiaoThong.Frm
{
    public partial class frmMain : Form
    {
        private UserModel curUser;
        public frmMain(UserModel um)
        {
            this.curUser=um;

            InitializeComponent();

            this.panel2.Controls.Add(new Module.HelloUser(um));

            new Classes.MoveFrame(this.panel6);

            InitMenu();
           
        }
        
        private void InitMenu()
        {
            btnThiTracNghiem.click+=new ClickHandler(btnMenuClick);
            btnThiTracNghiem.Click+=new EventHandler(btnMenuClick);
            btnThiTracNghiem.SetImage(AnToanGiaoThong.Properties.Resources.thitracnghiem);
            btnThiTracNghiem.SetText("Thi Trắc Nghiệm");

            btnOnThi.click+=new ClickHandler(btnMenuClick);
            btnOnThi.Click+=new EventHandler(btnMenuClick);
            btnOnThi.SetImage(AnToanGiaoThong.Properties.Resources.onthi);
            btnOnThi.SetText("Ôn Thi");

            btnSoanDe.click+=new ClickHandler(btnMenuClick);
            btnSoanDe.Click+=new EventHandler(btnMenuClick);
            btnSoanDe.SetImage(AnToanGiaoThong.Properties.Resources.soande);
            btnSoanDe.SetText("Soạn Đề");

            btnLuat.click+=new ClickHandler(btnMenuClick);
            btnLuat.Click+=new EventHandler(btnMenuClick);
            btnLuat.SetImage(AnToanGiaoThong.Properties.Resources.xemluat);
            btnLuat.SetText("Xem Luật");

            btnKinhNghiem.click+=new ClickHandler(btnMenuClick);
            btnKinhNghiem.Click+=new EventHandler(btnMenuClick);
            btnKinhNghiem.SetImage(AnToanGiaoThong.Properties.Resources.xemkinhnghiem);
            btnKinhNghiem.SetText("Xem Kinh Nghiệm");

            btnDiemNong.click+=new ClickHandler(btnMenuClick);
            btnDiemNong.Click+=new EventHandler(btnMenuClick);
            btnDiemNong.SetImage(AnToanGiaoThong.Properties.Resources.diemnong);
            btnDiemNong.SetText("Điểm nóng CSGT");

            btnThongKe.click+=new ClickHandler(btnMenuClick);
            btnThongKe.Click+=new EventHandler(btnMenuClick);
            btnThongKe.SetImage(AnToanGiaoThong.Properties.Resources.thongke);
            btnThongKe.SetText("Thống Kê");

            btnThoat.click+=new ClickHandler(btnMenuClick);
            btnThoat.Click+=new EventHandler(btnMenuClick);
            btnThoat.SetImage(AnToanGiaoThong.Properties.Resources.thoat);
            btnThoat.SetText("Thoát");

        }
        private void btnMenuClick(object sender, EventArgs e)
        {
            mButtonMenu t = sender as mButtonMenu;
            switch (t.Name)
            {
                case "btnThiTracNghiem":
                    MessageBox.Show("btnThiTracNghiem");
                    break;
                case "btnOnThi":
                    MessageBox.Show("btnOnThi");
                    break;
                case "btnSoanDe":
                    MessageBox.Show("btnSoanDe");
                    break;
                case "btnLuat":
                    MessageBox.Show("btnLuat");
                    break;
                case "btnKinhNghiem":
                    MessageBox.Show("btnKinhNghiem");
                    break;
                case "btnDiemNong":
                    MessageBox.Show("btnDiemNong");
                    break;
                case "btnThongKe":
                    MessageBox.Show("btnThongKe");
                    break;
                case "btnThongTinCaNhan":
                    MessageBox.Show("btnThongTinCaNhan");
                    break;
                default: break;
            }
        }
    }
}
