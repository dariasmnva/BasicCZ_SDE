/*С клавиатуры вводится целое число. 
Вывести третью цифру числа или сообщить, что её нет.
*/

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if(a>99)
{
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine($"Третьей цифры числа нет");
}
