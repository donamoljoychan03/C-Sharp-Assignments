using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject20Jan
{
    internal class Student
    {
        //public string Name { get; set; }

        //private int _age;

        //public int Age 
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if(value >=0 && value <= 100)
        //        {
        //            _age = value;

        //        }
        //    } 
        //}

        //        public void Display()
        //        {
        //            Console.WriteLine("Name : {0}, Age : {1}", Name, Age);
        //        }

        public string Name { get; set; }

        public int Mark1 { get; set; }

        public int Mark2 { get; set; }

        public int Total
        {
            get
            {
                return Mark1 + Mark2;
            }
        }
        public override string ToString()
        {
            return $" Name : {Name}  --  Total mark : {Total}";
        }
    }
}

