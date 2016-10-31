using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ucLogin;

using bussinessAccessLayer.DangNhap_DangKi;
namespace AnToanGiaoThong.Frm
{
    public partial class frmLogin : Form
    {

        loginBA lg = new loginBA();
        public frmLogin()
        {
            InitializeComponent();

            mLogin1.login+=new ucLogin.LoginHandler(loginMethod);
            mLogin1.register+=new ucLogin.pressRegisterHandler(pressRegisterMethod);
        }
        private void loginMethod(ucLogin.mLogin sender,EventArgs e)
        {
            string username = mLogin1.userid;
            string password = mLogin1.password;

            int result_login = lg.checkLogin(username, password);
            if (1==result_login)
            {
                MessageBox.Show("Nice");
                this.Hide();
                    
                new frmMain().Show();
            }else
            {
                MessageBox.Show("Fails");
            }

        }
        private void pressRegisterMethod(mLogin sender,EventArgs e)
        {
            Frm.frmRegister frm = new frmRegister();
            frm.Show();
                
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mLogin1_Load(object sender, EventArgs e)
        {

        }

        ///*Move form*/
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    if (m.Msg==WM_NCHITTEST)
        //        m.Result=(IntPtr)(HT_CAPTION);
        //}

        //private const int WM_NCHITTEST = 0x84;
        //private const int HT_CLIENT = 0x1;
        //private const int HT_CAPTION = 0x2;
        ///////
    }
}
