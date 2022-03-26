using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWiatrLab3ex1
{
    //klasa bazowa
    public class Shape
    {
        public int x;
        public int y;

        private bool RegularShape;
        protected string ShapeDescription;
        public Shape()
        {
            Console.WriteLine("Kontruktor domyslny z klasy Shape");
            x = 0;
            y = 0;
            RegularShape = false;
            ShapeDescription = "NA";
        }
        public Shape(int x, int y)
        {
            Console.WriteLine("Kontruktor z klasy Shape");
            this.x = x;
            this.y = y;
            RegularShape = false;
            ShapeDescription = "NA";
        }

        public void PrintShape()
        {
            Console.WriteLine($"[Klasa Shape] x: {x}, y: {y}");
        }

        public virtual int CalcArea()
        {
            Console.WriteLine("[Klasa Shape: metoda CalcArea");
            return -1;
        }
    }

    //klasa pochodna
    public class Rectangle : Shape
    {
        public string name;

        public Rectangle(int a, int b, string name) : base (a,b)
        {
            Console.WriteLine("\tKontruktor z klasy Rectangle");
            this.name = name;
        }

        public Rectangle(string name)
        {
            Console.WriteLine("\tKontruktor z klasy Rectangle");
            this.name = name;
        }

 

        public void PrintShape()
        {
            Console.WriteLine($"[Klasa Rectangle] x: {x}, y: {y}, name: {name}");
            Console.WriteLine($"Pola z klasy bazowej. ShapeDescription: " + ShapeDescription);
        }

        public override int CalcArea()
        {
            Console.WriteLine("[Klasa Rectangle: metoda CalcArea");
            return x * y;
        }
    }

    public class SpecialRectangle : Rectangle
    {
        public SpecialRectangle(string name) : base(name)
        {
            this.ShapeDescription = "SpecialRectangle";
        }
        public override string? ToString()
        {
            return $"[Klasa SpecialRectangle]. name: {this.name}, {this.ShapeDescription}, {this.x}, {this.y}]";
        }
    }

}
