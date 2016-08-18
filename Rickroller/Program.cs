using System;
using System.Diagnostics;

namespace Rickroller
{
    public static class Rickroller
    {
        public static void RickrollMe()
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
