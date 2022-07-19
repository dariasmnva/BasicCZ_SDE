// Вывести на экран таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите кол-во чисел для вывода:");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число"+"/"+"Квадрат");
for(int i=1; i<=N;i++)
Console.WriteLine(i+"/"+i*i);

