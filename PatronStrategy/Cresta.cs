using System;
using System.Collections.Generic;
using System.Text;

namespace PatronStrategy
{
    class Cresta:IOperacion
    {
        public double operacion(double a, double b)
        {
            return a - b;
        }
    }
}
