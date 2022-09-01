int[,] CreateMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write(" | ");
            Console.Write(mtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

void AverageOfColumns(int[,] mtrx)
{
    double sum = 0;

    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum += mtrx[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.WriteLine($" {Math.Round(sum / mtrx.GetLength(0), 2)}");

        sum = 0;
    }
}


int ArrayRows = Prompt("Введи число строк  ");
int ArrayColumns = Prompt("Введи чичло колонок ");
int min_Array = Prompt("Введи минимум в массиве ");
int max_Array = Prompt("Введи максимум в массиве ");

int[,] GenereatedMatrix = CreateMatrix(ArrayRows, ArrayColumns, min_Array, max_Array);
PrintMatrix(GenereatedMatrix);
AverageOfColumns (GenereatedMatrix);