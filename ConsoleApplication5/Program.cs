using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            print pt = new print(printt);
            
            pt(20);
            pt = pt + new print(printt);
        }
        delegate void print(int str);
        static void pr(string s)
        {
            Console.WriteLine(s);
        }
        static void printt(int k)
        {
            if(k<40)
            File.WriteAllText("C:\\Users\\dj\\Desktop\\latestversion\\txt\\kkkpppkk.txt", k.ToString());
        }
    }
}
