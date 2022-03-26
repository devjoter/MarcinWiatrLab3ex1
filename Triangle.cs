using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWiatrLab3ex1
{
    public class Triangle : Shape
    {
        public Triangle(int x, int y) : base(x, y)
        {
        }

        public override int CalcArea()
        {
            Console.WriteLine("[Klasa Triangle: metoda CalcArea");
            return (x * y) / 2;
        }
    }
}
