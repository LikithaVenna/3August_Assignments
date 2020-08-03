using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] myArray = { "Zebra", "Ant", "Owl", "Lion" };
            Console.WriteLine("-------Iterate Using For loop----------");
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);

            }
            Console.WriteLine("---------Iterate using For-each Loop-----------");
            foreach(string s in myArray)
                Console.WriteLine(s);
            Console.WriteLine("---------Iterate using while Loop-----------");
            int count = 0;
            while (count<myArray.Length)
            {
                Console.WriteLine(myArray[count]);
                count++;
            }
            Console.WriteLine("---------Iterate using do-while Loop-----------");
            int it = 0;
            do
            {
                Console.WriteLine(myArray[it]);
                it++;
            } while (it<myArray.Length);

            //Console.ReadLine();
            Console.WriteLine("---------After sorting--------");
            Array.Sort(myArray);
            foreach(string sort in myArray)
            {
                Console.WriteLine(sort);
            }
            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };

            Array.Sort(animals);
            Console.WriteLine("----------Sorting animals------------");
            foreach(string a in animals)
            {
                Console.WriteLine(a);
            }
            Array.Sort(places);
            Console.WriteLine("---------Sorting Places------------");
            foreach(string p in places)
            {
                Console.WriteLine(p);
            }

        }
    }
}
