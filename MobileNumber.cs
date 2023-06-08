using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class MobileNumber
    {
       public static void Mobile()
        {
            string pattern = "[91]{2}\\s[\\d]{10}";
            string mobile_Number = Console.ReadLine();

            Regex objRegEx = new Regex(pattern);

            if (objRegEx.IsMatch(mobile_Number))
            {
                Console.WriteLine($"Valid mobile number {mobile_Number}");
            }
            else
            {
                Console.WriteLine($"Invalid mobile number {mobile_Number}");

            }
        }
    }
}
