int number = new Random().Next(100,1000);

System.Console.WriteLine (number);

int First_digit = number/100%10;
int Second_digit = number/10%10;
int Third_digit = number%10;

int result =  First_digit*10 + Third_digit;
System.Console.WriteLine (result);