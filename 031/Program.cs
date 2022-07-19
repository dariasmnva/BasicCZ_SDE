// Показать кубы чисел, заканчивающихся на четную цифру.

Console.WriteLine("Введите кол-во чисел для вывода:");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число"+"/"+"Куб");
for(int i=1; i<=N;i++)
{
 if(i%2 == 0)
 {
    
    Console.WriteLine(i + "/" + i*i*i);
 }
}
