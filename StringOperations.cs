using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string sec;
            int opt;
            Console.WriteLine("Enter First String");
            first = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            sec = Console.ReadLine();
            Console.Write("1.Concatenation.\n2.Length of two strings.\n3-Substring.\n4.Replace.\n5.UpperCase.\n" +
                "6.LowerCase.\n7.Trim\n8.Split\n");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1: Console.WriteLine("Concatenation of Two strings is {0}",first+sec);
                    break;
                case 2: Console.WriteLine("Length of two strings are {0} {1}",first.Length,sec.Length);
                    break;
                case 3: Console.WriteLine("Substring of first string is {0}",first.Substring(5) );
                        Console.WriteLine("Substring of second string is {0}",sec.Substring(8));
                    break;
                case 4: Console.WriteLine("Replacing the string {0}",first.Replace('o','i'));
                        Console.WriteLine("Replacing the string {0}", sec.Replace('a', 'S'));
                    break;
                case 5: Console.WriteLine("UpperCase of the string {0}",first.ToUpper());
                        Console.WriteLine("UpperCase of the string {0}", sec.ToUpper());
                    break;
                case 6: Console.WriteLine("LowerCase of the string {0}", first.ToLower()); 
                        Console.WriteLine("LowerCase of the string {0}", sec.ToLower());
                    break;
                case 7: Console.WriteLine("Trim of the string {0}",first.Trim());
                        Console.WriteLine("Trim of the string {0}", sec.Trim());
                    break;
                case 8: Console.WriteLine("Splitting the string",first.Split('o'));
                        Console.WriteLine("Splitting the string", first.Split('i'));
                    break;
                default: Console.WriteLine("Make the choice again Enter 9 to exit");
                    break;
            }
        }
    }
}
