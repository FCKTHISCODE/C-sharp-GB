int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int number1 = Prompt("Input first number");
int number2 = Prompt("Input second number");
int min;
int max;

if (number1 > number2)
{
    max = number1;
    min = number2;

}
else
{
    max = number2;
    min = number1;
}


Console.WriteLine 