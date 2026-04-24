// Program to demonstrate interfaces 
using System;
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}
class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}