// Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

void PrintNumbersFromMtoN(int m, int n)
{
    if (m <= n)
    {
        if (m <= n && m % 2 == 0)
        {
            System.Console.Write($"{m}, ");
        }
        PrintNumbersFromMtoN(m + 1, n);
    }
}

int m = Prompt("Введи число M  ");
int n = Prompt("Введи число N  ");

PrintNumbersFromMtoN (m,n);