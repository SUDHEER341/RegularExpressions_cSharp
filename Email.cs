using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Email
    {
        public static void Email_Validation()
        {
            string emailPattern = ("[abc]{3}[.xyz]*@[bl]{2}.[co]{2}[.in]*");
            string email_1 = "abc.xyz@bl.co.in";
            string email_2 = "abc@bl.co";
            Regex objRegEx = new Regex(emailPattern);

            if(objRegEx.IsMatch(email_1) )
            {
                Console.WriteLine($"Valid email id {email_1}  ");
            }
            else  
            { 
                Console.WriteLine($"Invalid email id : {email_1}");
            }

            if( objRegEx.IsMatch(email_2))
            {
                Console.WriteLine($"Valid email id : {email_2}");
            }
            else
            {
                Console.WriteLine($"Invalid email id {email_2}");
            }
        }
    }
}
