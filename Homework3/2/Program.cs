int[] EnterCoordinates(string msg)
{
    int[] coordinates = new int[3];
    for (int i = 0; i < 3; i++)
    {
        System.Console.Write ($"{msg}   {i+1} coordinates ");
        string temp = Console.ReadLine();
        coordinates[i] = int.Parse(temp);
    }
        return coordinates;
}

//int Point1[] = new int [3];
//int Point2[] =new int [3];

int[] Point1 = EnterCoordinates("Enter coordinates of first point");
int[] Point2 = EnterCoordinates("Enter coordinates of second point");

double distance = Math.Pow((Math.Pow(Point2[0] - Point1[0], 2) + Math.Pow(Point2[1] - Point1[1], 2) + Math.Pow(Point2[2] - Point1[2], 2)), 0.5);
System.Console.Write(distance);