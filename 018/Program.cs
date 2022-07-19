// По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.

/* сумма двух чисел

int Sum(int a, int b)
{
    //тело подпрограммы
    return a+b;
}
//Основная программа
int s=Sum(2,2); //вызов подпрограммы
Console.WriteLine(Sum(2,2));

void Pause()
{
    Console.ReadKey();
}**/

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}
int a=25;
int b=5;
if (Check(a,b))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
