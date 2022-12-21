
int[] arrayPoints = { 8, 9, 4, 8, 10, 7, 7, 5, 6, 10 };
int[] arrayPoints1 = { 5, 6, 10, 7, 8, 9, 9, 6, 7, 10 };
int[] arrayPoints2 = { 7, 8, 9, 9, 6, 10, 10, 9, 7, 10 };
int[] arrayPoints3 = { 8, 8, 8, 9, 9, 9, 10, 7, 9, 10 };
int[] arrayPoints4 = { 6, 6, 6, 7, 5, 9, 5, 7, 8, 8, };

ShowStudentResult(arrayPoints);
ShowStudentResult(arrayPoints1);
ShowStudentResult(arrayPoints2);
ShowStudentResult(arrayPoints3);
ShowStudentResult(arrayPoints4);

 static void ShowStudentResult(int[] arrayPoints)
{
    float averagePoint = GetAveragePoints(arrayPoints);
    int minPoint = MinPoints(arrayPoints);
    int maxPoint = MaxPoints(arrayPoints);
    Console.WriteLine("Average point : " + averagePoint);
    Console.WriteLine("Min point : " + minPoint);
    Console.WriteLine("Max point : " + maxPoint);
}

static float GetAveragePoints(int[] arrayPoints)
{
    float averagePoint = 0f;
    for (int i = 0; i < arrayPoints.Length; i++)
    {
        averagePoint = averagePoint + arrayPoints[i];
    }
    averagePoint = averagePoint / arrayPoints.Length;
    return averagePoint;
}

static int MinPoints(int[] arrayPoints)
{
    int minPoint = arrayPoints[0];
    for (int i = 1; i < 10; i++)
    {
        if (minPoint > arrayPoints[i])
        {
            minPoint = arrayPoints[i];
        }       
    }
    return minPoint;
}

static int MaxPoints(int[] arrayPoints)
{
    int maxPoint = arrayPoints[0];
    for (int i = 1; i < 10; i++)
    {
        if (maxPoint < arrayPoints[i])
        {
            maxPoint = arrayPoints[i];
        }
    }
    return maxPoint;
}
