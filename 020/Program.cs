// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.


Console.WriteLine($"Введите значение x");
int X =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение y");
int y =Convert.ToInt32(Console.ReadLine());
if(X>0 & y>0)
{
    Console.WriteLine($"Это 1 четверть");
}
else if (X<0 & y>0)
{
    Console.WriteLine($"Это 2 четверть");
}
else if (X<0 & y<0)
{
    Console.WriteLine($"Это 3 четверть");
}
else if (X>0 & y<0)
{
    Console.WriteLine($"Это 4 четверть");
}