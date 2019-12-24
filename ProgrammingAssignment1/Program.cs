using System;

namespace ProgrammingAssignment1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, this application will calculate the distance and angle between two points!");

            //Read in and store point 1 input
            Console.Write("Please enter the x value for the first point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Please enter the y value for the first point: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.WriteLine();

            //Read in and store point 2 input
            Console.Write("Please enter the x value for the second point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Please enter the y value for the second point: ");
            float point2Y = float.Parse(Console.ReadLine());

            //Calculate distance between two points
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;
            float distance = (float) Math.Sqrt((double)(deltaX * deltaX + deltaY * deltaY));

            //Calculate angle in radians between two points
            float angle = (float)(Math.Atan2((double)deltaY, (double)deltaX));

            //Print distance and angle between points to user
            Console.WriteLine("The distance between the two points is " + distance);
            Console.WriteLine("The angle between the two points is " + angle * 180 / Math.PI);

        }
    }
}
