using System;
using ShapeTracker.Models; //new directive

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle();
      Console.WriteLine(testTriangle.GetType());
    }
  }
}