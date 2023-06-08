using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class LastName
    {
        public  static void Last_Name() 
        {

            string pattern = ("[A-Z]{1}[a-z]{2,}\\s[A-Z]{1}[a-z]{2,}");

            Console.WriteLine("Please enter the first name");
            string fullName = Console.ReadLine();

            Regex objRegEx = new Regex(pattern);

            if (objRegEx.IsMatch(fullName))
            {
                Console.WriteLine($"Pattern mathed for given name : {fullName}");
            }
            else
            {
                Console.WriteLine($"Pattern not matched for given name : {fullName} ");
            }
        }

    }
}
