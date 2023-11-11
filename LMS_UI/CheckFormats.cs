using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_UI
{
   public class CheckFormats
    {
        public bool checkName(string n)
        {
                if (n.Length > 0)
                {
                    foreach (char c in n)
                    {
                        if (c < 65 || c > 90 && c < 97 || c > 122)
                            return false;

                    }
                }
                else
                {
                    return false;
                }
                return true;
        }
        public bool checkCNIC(string cnic)
        {
            if (cnic.Length != 13)
                return false;

            foreach(char c in cnic)
            {
                if (c < 47 && c > 57)
                    return false;
            }

            return true;
        }
        public bool checkEmail(string email)
        {
            if (!email.Contains("@"))
                return false;
            if (!email.Contains("."))
                return false;
            if (email.Length < 5)
                return false;

            return true;
        }
        public bool checkContact(string c)
        {
            if (c.Length < 11)
                return false;
            foreach(char ch in c)
            {
                if (ch < 47 && ch > 57)
                    return false;
            }
            if (c.Substring(0, 2) != "03")
                return false;

            return true;
        }
    }
}
