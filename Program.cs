int[] arrayPoints = new int[10] { 8, 9, 2, 8, 10, 7, 7, 5, 6, 10 };
float averagePoint = 0f;
int min = arrayPoints[0];
int max = arrayPoints[0];

for (int i = 0; i < arrayPoints.Length; i++)
{
    averagePoint = averagePoint + arrayPoints[i];
}
averagePoint = averagePoint / arrayPoints.Length;
Console.WriteLine("Average point = " + averagePoint);

for (int i = 1; i < 10; i++)
{
    if (min > arrayPoints[i])
    {
        min = arrayPoints[i];
    }
    if (max < arrayPoints[i])
    {
        max = arrayPoints[i];
    }
}
Console.WriteLine("Max point = " + max);
Console.WriteLine("Min point = " + min);