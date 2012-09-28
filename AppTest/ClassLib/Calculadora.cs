using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class Calculadora
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Soma()
        {
            return X + Y;
        }

        public int Multiplica()
        {
            return X * Y;
        }
    }
}
