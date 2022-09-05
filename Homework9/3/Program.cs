// Напишите программу вычисления функции Аккермана с помощью рекурсии. 

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int Ackermann (int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Ackermann(n - 1, 1);
    else
        return Ackermann(n - 1, Ackermann(n, m - 1));
}

int m = Prompt("Введи число M  ");
int n = Prompt("Введи число N  ");

Console.WriteLine(Ackermann(m,n));