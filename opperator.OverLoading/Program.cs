using System;
using System.Collections;
using System.Collections.Generic;
using LearnCSharp.Library;

namespace LearnCSharp.Cmd
{
    public class Program
    {
        public static void Main()
        {

            
    

           
            var employees = new Employee[]
            {
                new Employee(){ FullName = "Warren Buffet"},
                new Employee(){ FullName = "Steve Jobs"},
                new Employee{ FullName ="Bill Gates"}
            };
            


            var employees2 = new Employee[]
            {
                new Employee(){ FullName = "Jim Ovia"},
                new Employee(){ FullName = "Aliko Dangote"},
                new Employee{ FullName ="Mike Adenuga"}
            };

            var staffs = new Staffs(employees);
            var staffs2 = new Staffs(employees2);


            foreach (var item in staffs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=================");
            foreach (var item in staffs)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
