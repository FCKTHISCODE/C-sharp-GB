int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}
int summacifr(int num)
{
    int summa = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;
        summa += digit;
    }
    return summa;
}

int number = Prompt("Введи число ");
Console.WriteLine(summacifr(number));