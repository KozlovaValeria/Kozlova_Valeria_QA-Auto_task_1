using Task_3;

Point point1 = new Point();
point1.Name = "Point 1";
point1.X = 3;
point1.Y = -2;

Point point2 = new Point();
point2.Name = "Point 2";
point2.X = 1;
point2.Y = 0;

Point point3 = new Point();
point3.Name = "Point 3";
point3.X = 6;
point3.Y = -3; 

Point point4 = new Point();
point4.Name = "Point 4";
point4.X = 1;
point4.Y = 7;

Point point5 = new Point();
point5.Name = "Point 5";
point5.X = 4;
point5.Y = 3;

Point point6 = new Point();
point6.Name = "Point 6";
point6.X = -3;
point6.Y = 5;

Point point7 = new Point();
point7.Name = "Point 7";
point7.X = 2;
point7.Y = 2;

Point point8 = new Point();
point8.Name = "Point 8"; 
point8.X = 8;
point8.Y = -1;

Point point9 = new Point();
point9.Name = "Point 9";
point9.X = 0;
point9.Y = 4;

Point point10 = new Point();
point10.Name = "Point 10";
point10.X = 3;
point10.Y = 3;

Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

foreach (Point point in points) 
{
    point.DisplayCoordinates();
}

double distance = PointDistance(point7, point2);
Console.WriteLine(distance);
static double PointDistance(Point point1, Point point2)
{
    double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    return distance;
}






