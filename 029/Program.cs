// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a>0)
{
    sum += a%10;
    a /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");