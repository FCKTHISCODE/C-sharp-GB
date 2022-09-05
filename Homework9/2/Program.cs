//Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int SummFromMtoN(int m, int n)
{
    if (n > m)
        return n + SummFromMtoN(m, n - 1);
    return m;
}

int m = Prompt("Введи число M  ");
int n = Prompt("Введи число N  ");

int Sum = SummFromMtoN(m, n);
Console.WriteLine($"Сумма чисел от M до N: " + Sum);