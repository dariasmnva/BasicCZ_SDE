//Вывести на экран числа от -N до N

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
for(int i=a;i<=b; i++)
{
    Console.Write($"{i} ");
}
Console.ReadKey(true);