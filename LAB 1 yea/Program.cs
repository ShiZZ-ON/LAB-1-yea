Console.Write("Координаты x1 = ");
    double x1 = double.Parse(Console.ReadLine());
Console.Write("Координаты y1 = ");
    double y1 = double.Parse(Console.ReadLine());


Console.Write("Координаты x2 = ");
    double x2 = double.Parse(Console.ReadLine());
Console.Write("Координаты y2 = ");
    double y2 = double.Parse(Console.ReadLine());


Console.Write("Координаты x3 = ");
    double x3 = double.Parse(Console.ReadLine());
Console.Write("Координаты y3 = ");
    double y3 = double.Parse(Console.ReadLine());

double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

double Perim = a + b + c;
Console.WriteLine (Perim);