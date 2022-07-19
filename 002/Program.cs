/* По двум заданным числам проверить является ли 
первое квадратом второго */
double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a*a==b)
{
    Console.WriteLine("b is square a");
}
else
{
    Console.WriteLine("b is't square a");
}
if (a==b*b)
{
    Console.WriteLine("a is square b");
}
else
{
    Console.WriteLine("a is't square b");
}