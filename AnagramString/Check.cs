using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramString
{
     public class Check
    {
        public void anagramno()
        {
            Console.WriteLine("Enter first string:");
            string firststr=Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string secondstr=Console.ReadLine();

            if (firststr.Length==secondstr.Length)
            {
                char[] ch1=(firststr.ToLower().ToCharArray());
                char[] ch2 = (firststr.ToLower().ToCharArray());
                Array.Sort(ch1);
                Array.Sort(ch2);
                string str1=new string(ch1);
                string str2=new string(ch2);

                if (str1==str2)
                {
                    Console.WriteLine("Anagarm  string");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }

        }


    }
}
