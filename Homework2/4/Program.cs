int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int Week_Day;
Week_Day = Prompt("Введи номер дня недели ");

if (Week_Day < 1 || Week_Day > 7)
{
    System.Console.WriteLine("Это не день недели ! ");
    return;
}

if (Week_Day == 6 || Week_Day == 7)
{
    System.Console.WriteLine("Да, выходной");
}
else
{
    System.Console.WriteLine("Нет, рабочий");
}