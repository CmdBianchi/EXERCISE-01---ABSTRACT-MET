using System;
using EXERCISE_01___ABSTRACT_MET.ENTITIES.Enums;
using EXERCISE_01___ABSTRACT_MET.ENTITIES;
using System.Collections.Generic;
namespace EXERCISE_01___ABSTRACT_MET {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shape: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine()); //------------------ > Chamada do ENUM

                if (ch == 'r' && ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.Write("Radius ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS: ");
                foreach(Shape shape in list) {
                    Console.WriteLine(shape.Area().ToString("F2"));
                }
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
