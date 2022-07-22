// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=4;
int [] a= new int[N];
Random random = new Random();
for(int i=0;i<a.Length; i++)
    a[i]=random.Next(0,11);


for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");

int sum = 0;
for(int i=0; i<a.Length;i=i+2)
    sum+=a[i];
Console.WriteLine();
Console.WriteLine(sum);