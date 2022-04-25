using System;

using System.Collections;

namespace LearnCSharp.Library
{
    public class Staffs : IEnumerable
    {

        public Staffs(Employee[] employees)
        {
            employeeEnumerator = new EmployeeEnumerator(employees);
        }

        private readonly EmployeeEnumerator employeeEnumerator;
        public IEnumerator GetEnumerator()
        {
             return employeeEnumerator;
        }
    }


    public class EmployeeEnumerator : IEnumerator
    {
        public EmployeeEnumerator(Employee[] employees)
        {
            this.EmployeeList = employees;
        }
        private int counter = -1;
        public Employee[] EmployeeList { get; set; }

        public object Current => EmployeeList[counter];

        public bool MoveNext()
        {
            counter++;

            if (counter > EmployeeList.Length - 1)
                return false;


            return true;
        }

        public void Reset()
        {
        }
    }

    public class Employee
    {
        public int Level { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"{this.FullName}";
        }
    }

}
