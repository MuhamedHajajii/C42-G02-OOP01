using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        /** What I Can Type Inside the struct
         * The Same As The Class
         * 1- Attributes [Field] Member Variable
         * 2- Functions [Constructor Function Getter Setter Methods]
         * 3- Properties [ Full Property , Automatic Property, Indexer ]
         * 4- Events
         * 
         * The Access Modifiers is 
         * 1- Public
         * 2- Internal
         * 3- Private
         */

        //public int x;
        //public int y;

        /**
         *     The Constructor is a special types of functions 
         *  1- Always Named with the same name of the class or the struct
         *  2- The Constructor Has Not Return
         *  
         *  The Main Responsibility to init the Defult Values for the attributes
         *  by defult in the struct the compiler will always generete parameter less constructor 
         *  init attributes of the struct with the defult value of its data type
         *  before .net 7 u must type the class attribute
         *  from c# 10 you can type it in the struct 
         *  before it the compiler always generate it by defutl and his main responsibility is initiat the attributes whth the defult values
         *  I can made my user defind constructor
         *  
         *  we can not make a struct and make it inherit from any other struct 
         *  but built in the struct will inherit from the class called struct
         *  even the enum has no inheritance direct but by defult they inherit build in from the microsoft
         *  in the integer data type they override the behavior of the to string and make it print the state of the class 
         */

        //public Point(int _X, int _Y)
        //{
        //    x = _X;
        //    y = _Y;
        //}
        //public Point(int _L)
        //{
        //    x =y= _L;
        //}

        ////public override string ToString()
        ////{
        ////    return base.ToString();
        ////}
        //public override string ToString()
        //{
        //    // This is refer to the caller
        //    return $"The Value of x = {this.x}\nThe Value of y = {this.y}";
        //}
    }
}
