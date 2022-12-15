// Задайте двухмерный массив. Найдите элементы, у которых оба индекса четные и замените элементы на их квадраты.
// 1 4 7 2     
// 5 9 2 3
// 8 4 2 4

// 1 4 7 2     
// 5 81 2 9
// 8 4 2 4

int[,] FindEvenNumbers(int[,] array)
{
    for (int i = 2; i < array.GetLength(0); i = i + 2 )
    {
        for (int j = 2; j < array.GetLength(1); j = j + 2 )
        {
                array[i,j] = array[i,j] * array[i,j];
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
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int [rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = new Random().Next(leftRange, rightRange  );
        }
    }
    return array;
}

int EnterNUmber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Получить от пользователя M и N.
int m = EnterNUmber("Введите значение M: ");
int n = EnterNUmber("Введите значение N: ");

// Создать двумерный массив.
int[,] matrix = CreateRandomArray(m, n, 1, 10);

// Вывести.
ShowArray(matrix);
System.Console.WriteLine();
int[,] array = FindEvenNumbers(matrix);
ShowArray(array);

