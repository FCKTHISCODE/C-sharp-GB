int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int number = Prompt("Input three digits number number ");
if (number >= 100 && number < 1000)
{
    int print_result = number / 10 % 10;
    System.Console.Write (print_result);
}
else
{
    System.Console.Write("It is not 3 digits number");
}