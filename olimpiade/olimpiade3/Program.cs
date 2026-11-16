using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace olimpiade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] s = File.ReadAllText("input.txt").Split(new char [] { ' ', '\n', '\r', '\t' },StringSplitOptions.RemoveEmptyEntries);

            int pos = 0;
            int n = int.Parse(s[pos++]);
            int[] boys = new int[n];

            for (int i = 0; i < n; i++)
            {
                boys[i] = int.Parse(s[pos++]);
            }

            int m = int.Parse(s[pos++]);
            int[] girls = new int[m];
            for (int i = 0; i < m; i++)
            {
                girls[i] = int.Parse(s[pos++]);
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (girls[i] <= boys[i])
                {
                    count++;
                }
            }

            File.WriteAllText("output.txt", count.ToString());
        }
    }
}
