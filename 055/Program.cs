// Дан целочисленный массив. 
//Найти среднее арифметическое каждого из столбцов.


int n = Int32.Parse(Console.ReadLine());
            
            int[,] arr = new int[n, n];
            Random random = new Random();
 
            for (short i = 0; i < n; i++)
                for (short j = 0; j < n; j++)
                    arr[i, j] = random.Next(1, 20);
 
            for(short i = 0; i < n; i++)
            {
                for (short j = 0; j < n; j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
 
            for (short i = 0; i < n; i++)
            {
                int sum = 0;
                for (short j = 0; j < n; j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine("Среднее арифметическое в {0} столбце: {1}", i, sum/n);
            }


