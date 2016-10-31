using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucRegister
{
    public class PasswordRule
    {
        const int MIN_LEN = 5;
        const int MAX_LEN = 15;


        bool ishaslenRequire = false;
        bool ishaslowerChar = false;
        bool ishasupperChar = false;
        bool isdemicalDigit = false;

        public PasswordRule()
        {

        }
        public bool IsPassword(string password, ref string reason)
        {

            if (password==null)
            {
                reason="Password must not be null";
                throw new ArgumentNullException();
            }

            ishaslenRequire=password.Length>=MIN_LEN&&password.Length<=MAX_LEN ? true : false;

            if (ishaslenRequire)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) ishasupperChar=true;
                    else if (char.IsLower(c)) ishaslowerChar=true;
                    else if (char.IsDigit(c)) isdemicalDigit=true;

                }
            }

            if (ishaslenRequire==false)
            {
                reason="5-15 characters (15) characters";
            }
            else if (ishaslowerChar==false)
            {
                reason="Contain at least one lower character (a-z).";
            }
            else if (ishasupperChar==false)
            {
                reason="Contain at least one upper character(A-Z)";
            }
            else if (isdemicalDigit==false)
            {
                reason="Contain at least one numeric (0-9)";
            }


            return ishaslenRequire&&ishasupperChar&&ishasupperChar&&ishasupperChar;
        }
    }//end class
}
