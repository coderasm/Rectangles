using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
   create all recangles, store them in an array.
   loop over rectangles, computing area and perimeter
   and store those in respective arrays. Sort the
   perimiter and area arrays and print.
   
   */
namespace Rectangles
{
  class Program
  {
    static void Main(string[] args)
    {
      int NUM_OF_RECTS = 5;
      //create rectangles
      RectEZ[] rectangles = {
        new RectEZ(2, 3),
        new RectEZ(4, 5),
        new RectEZ(3, 1),
        new RectEZ(6, 2),
        new RectEZ(3, 5)
      };
      //initialize perimeter and area arrays
      double[] perimeters = new double[NUM_OF_RECTS];
      double[] areas = new double[NUM_OF_RECTS];
      //loop over rectangles, calculate and store area and perimeter, then print
      for (int i = 0; i < NUM_OF_RECTS; i++)
      {
        perimeters[i] = rectangles[i].perimeter();
        areas[i] = rectangles[i].area();
        rectangles[i].print();
      }
      //sort perimeters and areas
      Array.Sort(perimeters);
      Array.Sort(areas);
      //print perimeters
      Console.Write("Perimeters Ascending: ");
      foreach (var perimiter in perimeters)
      {
        Console.Write(perimiter + ", ");
      }
      Console.WriteLine();
      //print areas
      Console.Write("Areas Ascending: ");
      foreach (var area in areas)
      {
        Console.Write(area + ", ");
      }
      Console.ReadKey();
    }
  }
}
