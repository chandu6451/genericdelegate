using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    delegate T GenericDelegate<T>(T val);

    class Program
    {
        public static int Addition(int val)
        {
            int sum = 0;
            for (int i = 1; i <= val; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public static string Reverse(string str)
        {
            string result = "";

            for (int i = str.Length-1; i >= 0; i--)
            {
                result = result + str[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            GenericDelegate<int> intDel = new GenericDelegate<int>(Addition);

            Console.WriteLine("Addition : " + intDel(10));

            GenericDelegate<string> strDel = new GenericDelegate<string>(Reverse);

            Console.WriteLine("Reverse String : " + strDel("Batch"));

            Console.ReadKey();
        }
    }
}
