// В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом

int N=10;
int [] a= new int[N];
Random random = new Random();
for(int i=0;i<a.Length; i++)
    a[i]=random.Next(10,99);

int Max =a[0],MaxIndex=0;
for (int i = 0; i < a.Length; i++)
{
	if (Max < a[i])
	{
		Max = a[i];
		MaxIndex = i;
	}
}

int Min = a[0],MinIndex=0;
for (int i = 0; i < a.Length; i++)
{
	if (Min > a[i])
	{
		Min = a[i];
		MinIndex = i;
	}
}
int r=Max-Min;

 for(int i=0; i<a.Length;i++)   
     Console.Write($"{a[i],4}");   
Console.WriteLine();  
Console.WriteLine($"Максимальное значение={Max}");   
Console.WriteLine($"Минимальное значение={Min}");   
Console.WriteLine($"Разница между максимальным и минимальным значением:{Max}-{Min}={r}");   
 
