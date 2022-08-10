int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int number = Prompt("Input number ");

if (number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}