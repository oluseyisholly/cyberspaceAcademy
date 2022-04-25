using System;

namespace AssignmentDelegates
{
    public delegate int ArithmeticOperationDelegate(int first, int seccond);

    internal class Program
    {
        static void Main()
        {
           
            ArithmeticOperationDelegate[] ArrayOfDelgeate = new ArithmeticOperationDelegate[3];

            
            for (int i = 0; i < ArrayOfDelgeate.Length; i++)
            {
                if ( i == 0)
                {
                    ArrayOfDelgeate[0] = ArithmeticOperation.Add;
                }
                else if(i == 1)
                {
                    ArrayOfDelgeate[1] = ArithmeticOperation.Minus;
                }
                else
                {
                    ArrayOfDelgeate[2] = ArithmeticOperation.Multiply;
                }
                var result = ArrayOfDelgeate[i];
                Console.WriteLine(result(12,7));

                //Console.WriteLine(ArithmeticOperation.Add(12, 7));
            }
            Console.WriteLine(ArithmeticOperation.Add(12,7));
        }
    }
    public class ArithmeticOperation
    {

        public static int Add(int i, int j)
        {
            return i + j;
        }
        public static int Minus(int i, int j)
        {
            return (i - j);
        }
        public static int Multiply(int i, int j) 
        { 
            return i * j; 
        }
    }
}
