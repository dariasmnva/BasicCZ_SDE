/*
int a = 2, b =3 ;
int s = a + b;
Console.WriteLine($"{a}+{b}={s}");
*/

// Ввести с клавиатуры целое число и вывести квадрат этого числа на экран 
int a;
int b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
Console.WriteLine($"{a}^2={b}");

