double[] CreateArray(int length, int min, int max)
{
    double[] answer = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.NextDouble()*((max+min)-min);
    }
    return answer;
}

void PrintArray(double[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

double MaxMInDifference(double[] array)
{
    double difference = array.Max()-array.Min();
    
    return difference;
}

///////////////////////////////////////////////////////////////////////////////////////////////////
int ArrayLenght = Prompt("Введи длину массива  ");
int min_Array = Prompt("Введи минимум в массиве  ");
int max_Array = Prompt("Введи максимум в массиве  ");

double[] ARRAY = CreateArray(ArrayLenght, min_Array, max_Array);
PrintArray(ARRAY);
//Console.WriteLine("Difference between maximum and minimum number in an array");
Console.Write($"Difference between maximum and minimum number in an array  {MaxMInDifference(ARRAY):f2}");
