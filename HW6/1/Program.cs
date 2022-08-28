Console.Write("Enter multiple numbers using ,  ");

int[] array = Array.ConvertAll(Console.ReadLine()!.Split(','), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество положительных чисел: " + count);