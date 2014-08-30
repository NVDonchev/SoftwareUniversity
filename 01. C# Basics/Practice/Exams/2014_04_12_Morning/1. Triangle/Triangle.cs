using System;

class Triangle
{
    public struct Point
    {
        public double x;
        public double y;
    }

    static void Main()
    {
        Point[] points = new Point[]
        {
            new Point() { x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()) },
            new Point() { x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()) },
            new Point() { x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()) },
        };

        double abTempX = Math.Pow((points[1].x - points[0].x), 2);
        double abTempY = Math.Pow((points[1].y - points[0].y), 2);

        double acTempX = Math.Pow((points[2].x - points[0].x), 2);
        double acTempY = Math.Pow((points[2].y - points[0].y), 2);

        double bcTempX = Math.Pow((points[2].x - points[1].x), 2);
        double bcTempY = Math.Pow((points[2].y - points[1].y), 2);

        double[] sideLengths = new double[]
            {
                Math.Sqrt(abTempX + abTempY),
                Math.Sqrt(acTempX + acTempY),
                Math.Sqrt(bcTempX + bcTempY),
            };

        if ((sideLengths[0] + sideLengths[1]) > sideLengths[2] &&
            (sideLengths[1] + sideLengths[2]) > sideLengths[0] &&
            (sideLengths[0] + sideLengths[2]) > sideLengths[1])
        {
            double perimeter = (sideLengths[0] + sideLengths[1] + sideLengths[2]) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - sideLengths[0]) * (perimeter - sideLengths[1]) * (perimeter - sideLengths[2]));

            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", Math.Round(area, 2));
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", Math.Round(sideLengths[0], 2));
        }
    }
}
