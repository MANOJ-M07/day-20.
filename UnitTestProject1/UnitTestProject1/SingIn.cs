using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class SingInManager
    {
        public static string SignIn(string userName, string userpwd)
        {
            string msg = " ";
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userpwd))
            {
                msg = "Provide username and password";
            }
            else
            {
                if ((userName == "sam1256") && (userpwd == "sam@1256@1256"))
                {
                    msg = "SignIn success ";
                }
                else
                {
                    msg = "Signin Fail";
                }

            }
            return msg;
        }
    }
}
