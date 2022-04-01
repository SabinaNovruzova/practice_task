using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    public class Student
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        private Student()
        {
            ++_id;
            Id = _id; ;
        }
        public Student(string fullName, double point):this()
        {
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"id:{Id} name:{FullName} point:{Point}");
        }
    }
}
