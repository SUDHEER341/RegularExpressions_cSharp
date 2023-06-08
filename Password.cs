using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Password
    {
        public static void ValidatePassword()
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8}$";

            string password = "Qrgjk%l2";

            Regex objRegEx = new Regex(pattern);

            if(objRegEx.IsMatch(password))
            {
                Console.WriteLine("valid password");
            }
            else
            {
                Console.WriteLine("invalid password");
            }
        }
    }
}
