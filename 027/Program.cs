// Возведите число А в натуральную степень B используя цикл.

Console.WriteLine ("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите степень B");
int B = Convert.ToInt32(Console.ReadLine());
int c=A;
for(int i=1;i<B;i++)
{
    A=A*c;
}
Console.WriteLine(A);