// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr;
arr=Creat2DArray(4,4);
int[,] Creat2DArray(int n, int m,int min=0,int max=100)
{
    int [,] a=new int[n,m]; //создаем массив
    Random random =new Random();
    for(int i=0;i<a.GetLength(0);i++)// перебираем строки 
    for (int j=0;j<a.GetLength(1);j++)//перебираем столбцы
        a[i,j]=random.Next(0,10);//0..1
    return a;    
}
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(($"{arr[i,j],4}"));
                }
                Console.WriteLine();
            }
 
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                var tmp = arr[arr.GetLength(1) - 1, i];
                arr[arr.GetLength(1) - 1, i] = arr[0, i];
                arr[0, i] = tmp;
            }
 
            Console.WriteLine("\nИзмененный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(($"{arr[i,j],4}"));
                }

            }
