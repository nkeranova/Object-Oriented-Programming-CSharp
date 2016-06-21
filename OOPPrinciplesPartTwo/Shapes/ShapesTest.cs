/// <summary>
///Problem 1. Shapes
///Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
///Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
///Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
///Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
/// </summary>
/// 

namespace Shapes
{
    using System;
    using Helper;
    using Shapes.Models;

    public class ShapesTest
    {
        public static void Main()
        {
            HelperMethods.DisplayTaskDescription(Constants.PathToTaskDescription);

            TestShapes();
        }

        public static void TestShapes()
        {
            double width = 2;
            double height = 3;

            var shapes = new Shape[] 
            {
                new Rectangle(width, height),
                new Triangle(width, height),
                new Circle(width)
            };

            Console.WriteLine("Width: {0}, Height: {1}", width, height);

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}, Surface: {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}