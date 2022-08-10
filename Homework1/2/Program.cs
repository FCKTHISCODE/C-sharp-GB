int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int number1 = Prompt("Input first number ");
int number2 = Prompt("Input second number ");
int number3 = Prompt("Input second number ");

int Maxvalue = number1;

if (number2 > Maxvalue)
{
    Maxvalue = number2;
}

if (number3 > Maxvalue)
{
    Maxvalue = number3;
}
Console.Write($"Max number is {Maxvalue}");
