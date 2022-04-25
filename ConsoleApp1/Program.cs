using System;

namespace LearnCSharp.Cmd
{   
    public class Program
    {
        static void Main()
        {
        peg:
            string input = Console.ReadLine();
            int? a = int.TryParse(input, out int age) ? age : 0; // you can use nullable<int>, a generic structure instead of int?
            int i = a.HasValue ? a.Value : 0;
            Console.WriteLine(i);
            goto peg;

            // nullable check
            string input1  = null;
            string output = input1 ?? "string was null";
            Console.WriteLine(output);

            if (input == null)
                output = "string as null";
            else
                output = input;

            


        }
       
        

    }
    public  class Animal
    {
        
    }
}


//using System;

//namespace LearnCSharp.Cmd
//{
//    public delegate int Arithmetic(int first, int second);
//    public delegate void ArithmeticDelegate();

//    public delegate Shape DrawDelegate();
//    public delegate void ShapeDelegate(int i);

//    public class Shape
//    {

//    }

//    public class Triangle : Shape
//    {

//    }
//    public class Program
//    {

//        static Triangle DrawTriangle()
//        {
//            return new Triangle();
//        }

//        static void Main()
//        {
//            ShapeDelegate shapeDelegate = i =>
//            {
//                Console.WriteLine(i);
//            };

//            ArithmeticDelegate arithmeticDelegate = () =>
//            {
//            };

//            DrawDelegate drawDelegate = DrawTriangle;

//            Arithmetic del = Add;
//            del += Minus;

//            //Annonymous delegate method
//            del += delegate (int first, int second)
//            {
//                return first + second;
//            };

//            del += delegate (int first, int second)
//            {
//                return first + second;
//            };

//            //Lambda Expression
//            del += (first, second) =>
//            {
//                return second + first;
//            };

//            del += (first, second) => second + first;


//            var result = del(39, 8);
//            Console.WriteLine(result);

//            //Console.WriteLine("+++++++++++++++++");
//            //del -= MyMethod2;
//            //del(80);

//        }

//        static int Add(int a, int b)
//        {
//            return a + b;
//        }

//        static int Minus(int x, int y)
//        {
//            return x - y;
//        }

//    }
//}


