using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olimpiada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = File.ReadAllText("input.txt").Split();

            int n = int.Parse(s[0]);
            int k1 = int.Parse(s[1]);
            int t1 = int.Parse(s[2]);
            int k2 = int.Parse(s[3]);
            int t2 = int.Parse(s[4]);

            int hodka1 = (n + k1 - 1) / k1;
            int hodka2 = (n + k2 - 1) / k2;

            int time1 = t1 * hodka1;
            int time2 = t2 * hodka2;
            int res;
            if(time1 > time2)
            {
                res = time2;
            }
            else
            {
                res = time1;
            }

            File.WriteAllText("output.txt", res.ToString());
        }
    }
}
