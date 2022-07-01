// задать двумерный массив и по запросу координат пользователя 
// сказать число или что его нет
// *Решение для простых смертных, кто считает строки и столбцы начиная с еденицы:


// int[,] CreateArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void PositionContent(int[,] array, int rowindex, int columnindex)
// {
//     if (rowindex >= 0 && rowindex <= array.GetLength(0)
//         && columnindex >= 0 && columnindex <= array.GetLength(1))
//     {
//         rowindex--;
//         columnindex--;
//         Console.WriteLine($"This position contains number {array[rowindex, columnindex]}");
//     }
//     else
//         Console.WriteLine($"Position with these indexes does not exist");
// }


// int[,] myArray = CreateArray(5, 7, 1, 20);
// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine("Choose row number:");
// int userRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Choose column number: ");
// int userColumn = Convert.ToInt32(Console.ReadLine());
// PositionContent(myArray, userRow, userColumn);

// Задать массив и найти среднее арифметическое по заданной колонке

int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ColumnAverage (int [,] array, int column)
{
    column--;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       sum = sum + array[i, column];
    }
    int result = Convert.ToInt32(sum / array.GetLength(0));
    return result;
}


int[,] myArray = CreateArray(4, 5, 1, 30);
ShowArray(myArray);
Console.WriteLine("Choose column number:");
int userColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Arithmetic mean in column {userColumn} is {ColumnAverage(myArray, userColumn)}");
