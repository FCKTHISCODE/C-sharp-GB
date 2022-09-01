double[,] CreateMatrix (int rows, int columns, int minNumber, int maxNumber)  
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble()*((maxNumber+minNumber)-minNumber);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mtrx)
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


int ArrayRows = Prompt("Введи число строк  ");
int ArrayColumns = Prompt("Введи чичло колонок ");
int min_Array = Prompt("Введи минимум в массиве ");
int max_Array = Prompt("Введи максимум в массиве ");

double [,] GenereatedMatrix = CreateMatrix (ArrayRows,ArrayColumns,min_Array,max_Array);
PrintMatrix (GenereatedMatrix);