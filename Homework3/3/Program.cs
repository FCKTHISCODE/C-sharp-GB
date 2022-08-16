int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

void Numcubed (int number)
{
    for (int i=1; i <= number; i++)
    {
    Console.WriteLine (i*i*i);
    }
}

int enterednumber = Prompt ("Enter a number");
Numcubed (enterednumber);