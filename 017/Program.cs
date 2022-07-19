// Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным.

int a =Convert.ToInt32(Console.ReadLine());
bool b=a==6, c=a==7;
if (b||c)
{
    System.Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}