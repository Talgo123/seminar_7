// Задайте двухмерный массив рамера m и n.
// каждый элемент в массиве находится A[i,j] = i + j
// Выведите полученный массив на экран 


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

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int [rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = i + j;
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


int m = EnterNUmber("Введите значение M: ");
int n = EnterNUmber("Введите значение N: ");

int[,] matrix = CreateArray(m, n);
ShowArray(matrix);