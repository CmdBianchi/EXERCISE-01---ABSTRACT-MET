using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_01___ABSTRACT_MET.ENTITIES.Enums;
namespace EXERCISE_01___ABSTRACT_MET.ENTITIES {
    //------------------------------- START -------------------------------//
    abstract class Shape {
        public Color color  { get; set; }

        //---------> CONSTRUCTOR

        public Shape(Color color) { 
            this.color = color;
        }

        //---------> MET
        public abstract double Area();

    }
    //-------------------------------- END -------------------------------//
}
