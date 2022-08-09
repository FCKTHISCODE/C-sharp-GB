Console.WriteLine ("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
int output = 2;

while (output <= number)
{
    Console.WriteLine (output);
    output+=2;
}
