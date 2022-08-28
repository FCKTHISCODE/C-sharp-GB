//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.


int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}


////////////////////////////////////////////////////
int k1 = Prompt("Enter k1:  ");
int k2 = Prompt("Enter k2:  ");
int b1 = Prompt("Enter b2:  ");
int b2 = Prompt("Enter b2:  ");

if (k1 == k2)
{
    if (k1 == k2 && b1 == b2) 
    Console.WriteLine($"Прямые совпадают");
    
    else Console.WriteLine($"Прямые параллельны");
}
else
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения: ({x}; {y})");
}