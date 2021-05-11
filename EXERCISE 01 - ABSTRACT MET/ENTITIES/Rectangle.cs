using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_01___ABSTRACT_MET.ENTITIES.Enums;
namespace EXERCISE_01___ABSTRACT_MET.ENTITIES {
    //------------------------------- START -------------------------------//
    class Rectangle : Shape {
        public double Width { get; set; }
        public double Height { get; set; }

        //---------> CONSTRUCTOR
        public Rectangle(double width, double height, Color color) : base(color) {
            Width = width;
            Height = height;
        }

        //---------> MET
        public override double Area() {
            return Width * Height;
        }
    }
    //-------------------------------- END -------------------------------//
}
