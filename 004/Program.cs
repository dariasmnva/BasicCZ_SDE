// По заданному с клавиатуры номеру дня недели вывести его название

int a;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
switch(a)
{
    case 1: 
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
    default:
    Console.WriteLine("Ошибка");
    break;
}