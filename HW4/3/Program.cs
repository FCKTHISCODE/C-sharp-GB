int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array) // вывод массива на консоль
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

int secondmax(int[] array)  //пока просто максимум возвращает, не готово
{
    int maxvalue = array.Max();
    return maxvalue;
}

int ArrayLenght = Prompt("ВВеди длину массива  ");
int min_Array = Prompt("ВВеди минимум в массиве  ");
int max_Array = Prompt("ВВеди максимум в массиве  ");

int[] ARRAY = CreateArray(ArrayLenght, min_Array, max_Array);
PrintArray(ARRAY);

Console.WriteLine(secondmax(ARRAY));  //печатает пока максимум в массиве
