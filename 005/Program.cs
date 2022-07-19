// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a, b, c;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
s=Console.ReadLine();
c=Convert.ToDouble(s);
if(a>b&&a>c) 
{
    Console.WriteLine($"max={a}");
}
else if (b>a&&b>c)
{
    Console.WriteLine($"max={b}");
}
else
{
    Console.WriteLine($"max={c}");
}
