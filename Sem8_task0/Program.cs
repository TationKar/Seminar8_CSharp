/**Задача 53:**Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2*/
Console.Clear();
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

        static void swapArr(ref int[,] arr)
        {
            int[,] newArr = new int[arr.GetLength(0),arr.GetLength(1)];

            for(int i = 0; i < arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1);j++)
                {
                    if (i == 0)
                    {                        
                        newArr[i,j] = arr[arr.GetLength(0) - 1,j];
                        continue;
                    }
                    if (i == arr.GetLength(0) - 1)
                    {
                        newArr[i, j] = arr[0, j];
                        continue;
                    }
                    newArr[i, j] = arr[i, j];
                }
            }
            arr = newArr;
        }
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("Введите количество элементов в строке: ");
            int cols = int.Parse(Console.ReadLine()!);
            int[,] arr = new int[rows, cols];

            rndArr(arr);
            showArr(arr);
            swapArr(ref arr);
            Console.WriteLine("-------------------------------");
            showArr(arr);
            Console.ReadLine();
