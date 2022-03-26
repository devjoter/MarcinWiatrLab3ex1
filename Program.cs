using MarcinWiatrLab3ex1;
// 1. Dziedziczenie
Shape s = new Shape(5, 5);
s.PrintShape();

Rectangle r = new Rectangle(3,3, "Prostokat");
r.PrintShape();

// 2. Polimorfizm

//statycznie 
Box b = new Box(5, 5, 5, "Box_b");
b.ShowBox(5);
b.ShowBox("pudelko");
b.ShowBox(true);

//Box b2 = b + b; niepoprawnie
//przeciazenie operator
Box b1 = new Box(10, 10, 10, "Box_b1");

Box b2 = b + b1;
b2.PrintShape();

int aa = 4;
int bb = 4;
if (aa == bb)
    Console.WriteLine("aa jest rowne bb");

Box b3 = new Box(10, 10, 10, "Box_b3");

if (b1 == b3)
    Console.WriteLine($"Pudelka {b.name} i {b3.name} sa gabarytowo takie same");

if (b1 != b3)
    Console.WriteLine($"Pudelka {b.name} i {b3.name} sa gabarytowo rozne");


// 3. Polimorfizm dynamiczny  (pozne wiazanie)

void ShowShape(Shape s)
{
    int ShapeArea;
    ShapeArea = s.CalcArea();
    Console.WriteLine($"Pole danej figury: {ShapeArea}.");
}

Triangle t = new Triangle(10, 50);
ShowShape(r);
ShowShape(b);
ShowShape(t);

// 4. Klasa abstrakcyjana
// Shapes shapes = new Shapes(); Nie mozna utworzyc obiektu klasy abstrakcyjnej
//Mozna utworzyc obiekt klasy pochodnej


Console.WriteLine("-------------------");
Square sq = new Square(8, 8);
Console.WriteLine("Pole kwadratu: " + sq.CalcArea());

// 5. Hermetyzacja
// public, private, protected
//internal, protected internal

Rectangle rectangle = new Rectangle(10, 10, "Rect1");
rectangle.PrintShape();
SpecialRectangle sp = new SpecialRectangle("SpecialRectangle Test");
Console.WriteLine("sp: " + sp.ToString());

// 6. Interfejsy

Transactions tr = new Transactions("Wplata", 99);
tr.ShowDetails();

// 7. Wlasciwosci

tr.TransactionQty = -100;
tr.TransactionName = null;
tr.ShowDetails();

// 8. Typ pusty

int? n1 = null;
int? n2 = 10;
double? n3 = new double?();
bool? n4 = null;

n3 = n1 ?? 3.14;

if (n4 == null)
    n4 = false;

Console.WriteLine($"typ pusty: {n1}, {n2}, {n3}, {n4}");
Console.ReadKey();