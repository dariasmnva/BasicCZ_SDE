// See Задать номер четверти, 
// показать диапазоны для возможных координат.

Console.WriteLine($"Введите номер четверти от 1 до 4");
int a = Convert.ToInt32(Console.ReadLine());
bool b=a==1, c=a==2, d=a==3, e=a==4;
if (b)
{
    Console.WriteLine($"Диапозон x>0,y>0");
}
else if (c)
{
    Console.WriteLine($"Диапозон x<0, y>0");
}
else if (d)
{
    Console.WriteLine($"Диапозон x<0, y<0");
}
else if (e)
{
    Console.WriteLine($"Диапозон x>0, y<0");
}
else
{
    Console.WriteLine($"Ошибка!");
}