using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_01___ABSTRACT_MET.ENTITIES.Enums;
namespace EXERCISE_01___ABSTRACT_MET.ENTITIES {
    //------------------------------- START -------------------------------//
    class Circle : Shape {
        public double Radius { get; set; }

        public Circle(double radius, Color color): base(color) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }

    }
    //-------------------------------- END -------------------------------//
}
