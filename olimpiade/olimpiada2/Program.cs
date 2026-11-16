using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olimpiada2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []s = File.ReadAllLines("input.txt");

            string ch1 = s[0];
            string ch2 = s[1];
            string ch3 = s[2];

            string res = "";
            for (int i = 0; i < ch1.Length; i++)
            {
                char max = ch1[i];

                if (ch2[i] > max)
                {
                    max = ch2[i];
                }

                if (ch3[i] > max)
                {
                    max = ch3[i];
                }

                res += max;
            }

            File.WriteAllText("output.txt",res);
        }
    }
}
