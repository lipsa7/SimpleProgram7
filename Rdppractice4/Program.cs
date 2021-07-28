using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(UserProgramCode.removeVowelEven(str));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static string removeVowelEven(string str)
        {
            int max = str.Length;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(str[i]);
                }
                else if (i % 2 != 0)
                {
                    if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u')
                    {
                        sb.Append(str[i]);
                    }
                }
                
            }

            return sb.ToString();

            //return str;
        }
    }
}
