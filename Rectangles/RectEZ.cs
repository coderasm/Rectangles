using System;
namespace Rectangles
{
  class RectEZ
  {
    private double length = 1;
    private double width = 1;

    public RectEZ(double length, double width)
    {
      if (length > 0 && width > 0)
      {
        this.length = Math.Abs(length);
        this.width = Math.Abs(width);
      }
    }

    public void setWidth(double width)
    {
      if (width > 0)
        this.width = Math.Abs(width);
    }

    public void setLength(double length)
    {
      if (length > 0)
        this.length = Math.Abs(length);
    }

    public double area()
    {
      return length * width;
    }

    public double perimeter()
    {
      return 2 * length + 2 * width;
    }

    public void print()
    {
      Console.WriteLine("Rectangle: Length: " + length + ", Width: " + width + ", Area: " + area() + ", Perimeter: " + perimeter());
    }
  }
}
