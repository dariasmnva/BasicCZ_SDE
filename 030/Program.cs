// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите кол-во чисел для вывода:");
int N= Convert.ToInt32(Console.ReadLine());
int p=1;
Console.WriteLine($"Произведение чисел от 1 до {N}:");
for (int i=1;i<=N;i++)
{
    p=p*i;
}
Console.WriteLine(p);