// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\

static void rndArr(int[,] arr, int val)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(val + 1);
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

static int[] trans(int[,] arr)
{
    int[] newArr = new int[arr.GetLength(0) * arr.GetLength(1)];

    for (int i = 0, k = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++, k++)
        {
            newArr[k] = arr[i, j];
        }
    }
    return newArr;
}

static void Sort(int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
    {
        for (int k = 0, j = 0; k < newArr.Length; k++)
        {
            if (newArr[i] < newArr[k])
            {
                j = newArr[k];
                newArr[k] = newArr[i];
                newArr[i] = j;
            }
        }
    }
}

void CounterArrIn(int[] inArray)
{    
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов в строке: ");
int cols = int.Parse(Console.ReadLine());

Console.Write("Введите размер диапазона для поиска: ");
int val = int.Parse(Console.ReadLine());

int[,] arr = new int[rows, cols];

rndArr(arr, val);

showArr(arr);

int[] newArr = new int[arr.GetLength(0) * arr.GetLength(1)];
newArr = trans(arr);

Sort(newArr);

Console.WriteLine("---------------------------------");

Console.WriteLine(string.Join(", ", newArr));

CounterArrIn(newArr);
Console.ReadLine();
