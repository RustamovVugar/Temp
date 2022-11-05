using System;

namespace KC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Celsius c1 = new Celsius(0);
            Kelvin k1 = c1;
            Console.WriteLine(k1.Degree);
        }
    }
}
