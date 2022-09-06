//Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

void PrintOddNumbersMtoN(int m, int n)
{
    if (m <= n) 
    {
        if (m % 2 == 0) System.Console.Write(m);
        PrintOddNumbersMtoN(m + 1, n);
    }

    if (m > n) return;
    if (m % 2 == 0) System.Console.Write(m);
    PrintOddNumbersMtoN(m + 1, n);
}

int emteredm = Prompt("Введи число M  ");
int emteredn = Prompt("Введи число N  ");

PrintOddNumbersMtoN (emteredm,emteredn);