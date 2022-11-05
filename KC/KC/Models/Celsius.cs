using System;
using System.Collections.Generic;
using System.Text;

namespace KC.Models
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            Kelvin k1 = new Kelvin((celsius.Degree * 9 / 5) + 32);
            return k1;
        }
    }
}
