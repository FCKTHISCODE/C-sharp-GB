// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int Number = Prompt("Введи число  ");

if (Number > 99)
{
    while (Number > 1000)
    {
       Number = Number / 10;
    }
    int result = Number % 10;
    System.Console.Write(result);
}
else
{
    System.Console.Write("нет Третьей цифры");
}
