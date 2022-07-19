/* С клавиатуры вводятся два числа a и b. 
Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
*/

double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if(a%b == 0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else 
{
    Console.WriteLine(a/b);
}