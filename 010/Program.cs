// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write(a%10);
