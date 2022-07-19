// Написать программу вычисления значения функции y = sin(a). (Класс Math)

double a;
double y;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
y=Math.Sin(a);
Console.WriteLine ($"y={y}");