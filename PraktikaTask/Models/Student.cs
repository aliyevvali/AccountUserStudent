using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikaTask.Models
{
    class Student
    {
        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public double Point { get; set; }
        private Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string fullname, double point)
        {
            Fullname = fullname; Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id : {Id} , Full Name : {Fullname} , Point : {Point}");
        }
    }
}
