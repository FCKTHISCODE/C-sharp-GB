void Reversestring(string reverstr)
{
    for (int i,tmp = 0, j = str.Length (reverstr)-1;i++,j--)
    {
        tmp = string [i];
        string [i] = string [j];
        string [j] = tmp;
    }
}
//string reverce_enterednumber2=


string enterednumber1 = Prompt ("Enter a number");
///string enterednumber2 = Prompt("Enter a number");
string reverce_enterednumber1 = Reversestring (enterednumber1);
System.Console.WriteLine (reverce_enterednumber1);
