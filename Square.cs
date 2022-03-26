using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWiatrLab3ex1

{
    public class Square : Shapes
    {
        int x, y;

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public override int CalcArea()
        {
            return x * y;
        }
    }
}
