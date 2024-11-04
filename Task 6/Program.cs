using System;

public class GeometryCalculator
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double CalculateCubeVolume(double sideLength)
    {
        return Math.Pow(sideLength, 3);
    }
}
