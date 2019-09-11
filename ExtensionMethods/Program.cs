using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 09, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
