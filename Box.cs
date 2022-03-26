using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWiatrLab3ex1
{
    public class Box : Shape
    {
        public int z;
        public string name;

        public Box()
        {
            name = "NA";
            z = 0;
        }
        public Box(int x, int y, int z, string name) : base(x, y)
        {
            this.z = z;
            this.name = name;
        }
        //przeciazenie metody
        public void ShowBox(int i)
        {
            Console.WriteLine("ShowBox int: " + i);
        }

        public void ShowBox(string s)
        {
            Console.WriteLine("ShowBox string: " + s);
        }

        public void ShowBox(bool b)
        {
            Console.WriteLine("ShowBox bool: " + b);
        }

        //przeciazenie
        public static Box operator + (Box b1, Box b2)
        {
            Box box = new Box();
            box.x = b1.x + b2.x;
            box.y = b1.y + b2.y;
            box.z = b1.z + b2.z;
            box.name = "Suma pudelek:" + b1.name + "+" + b2.name;
            return box;
        }
        public static bool operator ==(Box b1, Box b2)
        {
            if (b1.x == b2.x && b1.y == b2.y && b1.z == b2.z)
                return true;
            return false;   
        }

        public static bool operator !=(Box b1, Box b2)
        {
            if (b1.x != b2.x || b1.y != b2.y || b1.z != b2.z)
                return true;
            return false;
        }


        public void PrintShape()
        {
            Console.WriteLine($"[Klasa Box] x: {x}, y: {y}, z: {z}, name: {name}");
        }

        public override int CalcArea()
        {
            Console.WriteLine("[Klasa Box: metoda CalcArea");
            return x * y * z;
        }

    }
}
