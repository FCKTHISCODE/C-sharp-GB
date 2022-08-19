int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int AvstepebiB(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}

int number1 = Prompt("Введи число  ");
int number2 = Prompt("В какую положительную степень возвести  ");
int num1_todegree_num2 = AvstepebiB (number1, number2);
Console.WriteLine (num1_todegree_num2);
