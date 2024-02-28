



int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount]; //матрица будет создаваться на х строки и у элементов в каждой строке

    Random rnd = new Random(); // объект Random создается при каждом обращении - замедляет процесс исполнения - поэтому вынесен за пределы цикла

    for (int i = 0; i < matrix.GetLength(0); i++) //пройти по строкам двумерного массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//пройти по элементам строки двумерного массива
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    // как для заполения, так и для вывода массива -  надо перебрать все его элементы
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);