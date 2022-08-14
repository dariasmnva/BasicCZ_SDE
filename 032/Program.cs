// Задать массив из 8 целых элементов и вывести их на экран.

//Инициализация переменн
int [] a;



//Ввод данных
Init (out a);
//Обработка данных


//Вывод резльтатов
Print(a);



void Init(out int [] a,int Lenght=8, int min=0,int max=10)
{
    a=new int[Lenght];
    Random random = new Random();
    for(int i=0;i<a.Length; i++)
    a[i]=random.Next(min,max+1);
}    
void Print(int[] a)
{
    for (int i=0; i<a.Length; i++)
    Console.Write($"{a[i],4}");
}

