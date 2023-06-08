using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class FirstName
    {
        public static void First_Name()
        {
            string pattern = ("[A-Z]{1}[a-z]{2,}");

            Console.WriteLine("Please enter the first name");
            string firstName =Console.ReadLine();

            Regex objRegEx = new Regex(pattern);

            if(objRegEx.IsMatch(firstName))
            {
                Console.WriteLine($"Pattern mathed for given name : {firstName}" );
            }
            else
            {
                Console.WriteLine($"Pattern not matched for given name : {firstName}");
            }
        }
        
            
    }
}
