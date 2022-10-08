// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

Console.WriteLine("введите координаты в формате x, a, y, b");

double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double distancePoints = Math.Sqrt(((x1 - x2) * (x1 - x2))  + ((y1 - y2) * (y1 - y2)));

Console.WriteLine(distancePoints);