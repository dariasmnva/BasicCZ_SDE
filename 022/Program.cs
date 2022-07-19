// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine($"Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if(a%10 == a/10000 & a%100/10 == a%10000/1000)
{
    Console.WriteLine($"является палиндромом");
}
else
{
    Console.WriteLine($"не является палиндромом");
}