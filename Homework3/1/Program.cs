Console.WriteLine ("Enter 5 digit number ");
string inputnumber = System.Console.ReadLine();

if (inputnumber [0] == inputnumber [4] && inputnumber [1] == inputnumber [3])
{
    System.Console.WriteLine("Palindromic number");
}

else
{
    System.Console.WriteLine("Not Palindromic number");
}