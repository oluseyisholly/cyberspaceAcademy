using System;

namespace Excercising.Delegate
{
    public delegate void Mydelegate(int i);
    public class Program
    {
        static void Main()
        {
            
            Mydelegate del = Mymethod1;
            del += Mymethod2;
            del(5);
            Console.WriteLine("++++++++++++++");
            del -= Mymethod2;
            del -= Mymethod1;
            del(4);
            Console.WriteLine(null);
        }
        static void Mymethod1(int i)
        {
            Console.WriteLine($"mymethod1: {i}");
        }
        static void Mymethod2(int i)
        {
            Console.WriteLine($"mymeth0d 2: {i}");
        }
        // Lambda Expressions
        del += (int first, ) =>
        {
            return second + first
    };
    del += (first, second) => second + first;
        
        // ano

    }


}
