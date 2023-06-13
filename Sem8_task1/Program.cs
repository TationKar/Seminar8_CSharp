// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
static void rndArr(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(51);
                }
            }
        }

        static void showArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] swapArr(int[,] arr)
        {
            int[,] newArr = new int[arr.GetLength(1),arr.GetLength(0)];

            for(int i = 0; i < arr.GetLength(1);i++)
            {
                for(int j = 0; j < arr.GetLength(0);j++)
                {
                    newArr[i,j] = arr[j,i];
                }
            }
            return newArr;
        }

            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество элементов в строке: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] arr = new int[rows, cols];

            rndArr(arr);

            showArr(arr);

            
            Console.WriteLine("-------------------------------");
            showArr(swapArr( arr));
            Console.ReadLine();
