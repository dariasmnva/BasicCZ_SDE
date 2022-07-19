// Найти сумму чисел от 1 до А

Console.WriteLine("Введите кол-во чисел для вывода:");
int A= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {A}:");
Console.Write(A*(A+1)/2);