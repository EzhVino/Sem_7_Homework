// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет
// *3й метод PositionContent приспособлен для простых смертных пользователей, кто считает строки и столбцы начиная с еденицы:


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

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void ColumnAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double result = sum / array.GetLength(0);
        Console.Write(result + " | ");
    }
}


int[,] myArray = CreateArray(4, 5, 1, 30);
ShowArray(myArray);
Console.WriteLine();
ColumnAverage(myArray);

//* Вопрос на семинар: как округлить result до десятых. Как добавить пробел после вывода отформатированного результата? 
//* и почему не форматируется до десятых вот так - Console.Write("{0:f1}", result + " ");

