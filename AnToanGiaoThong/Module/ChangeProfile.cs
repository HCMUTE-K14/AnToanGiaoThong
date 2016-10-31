using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnToanGiaoThong.Classes;
using bussinessAccessLayer.DangNhap_DangKi;
namespace AnToanGiaoThong.Module
{
    public partial class ChangeProfile : UserControl
    {
        public ChangeProfile(string username)
        {
            this.username=username;
            InitializeComponent();

        }
        DataTable dt = new DataTable();
        loginBA loginBA = new loginBA();
        public string username;
        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            dt=loginBA.infoUser(username).Tables[0];

            lblUsername.Text=dt.Rows[0][0].ToString();
            lblHoTen.Text=dt.Rows[0][2].ToString();
            lblNgaySinh.Text=((DateTime)dt.Rows[0][3]).ToShortDateString();
            lblQueQuan.Text=dt.Rows[0][4].ToString();
            Function f = new Function();
            pictureBox1.Image=f.ResizeImage(f.Byte2Image((byte[])dt.Rows[0][5]), pictureBox1.Width, pictureBox1.Height);
        }

        private void suaClick(Label lb,TextBox tb)
        {

            if (lb.Text=="Sửa")
            {
                lb.Text="Lưu";
                tb.Enabled=true;
            }
            else
            {
                //Save vào CSDL
                lb.Text="Sửa";
                tb.Enabled=false;
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            suaClick(this.label10,this.lblHoTen);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            suaClick(this.label11, this.lblNgaySinh);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            suaClick(this.label12, this.lblQueQuan);
        }
    }
}
