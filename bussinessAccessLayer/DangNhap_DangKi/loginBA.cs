using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using dataAccessLayer;
namespace bussinessAccessLayer.DangNhap_DangKi
{
    public class loginBA
    {

        dataAccess da;
        public loginBA()
        {
            da=new dataAccess();
          
        }
        public int checkLogin(string username,string password)
        {
            return da.checkUserLogin("spLogin", System.Data.CommandType.StoredProcedure, 
                new System.Data.SqlClient.SqlParameter("@username", username), 
                new System.Data.SqlClient.SqlParameter("@password", password));

        }
        

    }//end class
}
