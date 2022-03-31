using System;
using System.Collections.Generic;
using System.Text;

namespace KelvinToCelsius.Models
{
    class Kelvin
    {
        

        public float Degree { get; set; }

        
        

        public Kelvin(float degree)
        {
            Degree = degree;
        }

        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree -Convert.ToSingle(273.15));
        }
    }
}
