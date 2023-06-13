// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,] ChangeRowsColumns(int[,] array2)
{
    int[,] arrayNew = new int[array2.Length];
    for (int i = 0; i < array2.GetLength(1); i++)
    { 
        for (int j = 0; j < array2.GetLength(0); j++)
        {
        arrayNew[i,j] = array2[j,i];
        Write($"{array2[j,i], 5}");  
        }     
        WriteLine();
    }
    return arrayNew;
}
Console.WriteLine();

ChangeRowsColumns(array);