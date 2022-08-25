// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int recursion(int m, int n) 
{
        
        if (m == 0) 
        {
            return n + 1;
        } 
        else if (n == 0 && m > 0) 
        {
            return recursion(m - 1, 1);
        } 
        else 
        {
            return recursion(m - 1, recursion(m, n - 1));
        }
}
Console.WriteLine((recursion(N,M)));