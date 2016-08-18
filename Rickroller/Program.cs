using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process.Start(@"https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                Console.WriteLine("Congrats, you've been rickrolled");
            }
            catch
            {
                Console.WriteLine("Something went wrong. Probably you're not goot enough to be rickanrolled");
            }
        }
    }
}
