using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikaTask.Models
{
    class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= 5 || value <= 18)
                {
                    _studentLimit = value;
                }
                else
                {
                    throw new Exception("limiti ashdiniz");
                }
            }
        }
        private Student[] _students = new Student[0];


        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo; StudentLimit = studentLimit;
        }

        public bool CheckGroupNo(string groupNo)
        {
            bool okey = false;
            if (groupNo.Length == 5 && !string.IsNullOrEmpty(groupNo) && !string.IsNullOrWhiteSpace(groupNo))
            {
                bool hasUppers = false;
                bool hasDigits = false;
               

                if (okey)
                {

                }

            }
            return false;

        }
        public void AddStudent(Student student)
        {
            if (_students.Length <= _studentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            throw new Exception("Limiti ashdiniz");
        }

        public Student GetStudent(int? id)
        {
            if (id != null)
            {
                foreach (var item in _students)
                {
                    if (item.Equals(id))
                    {
                        return item;
                    }
                }
            }
            throw new Exception("Verdiyiniz Id de Student tapilmadi");

        }
        public void GetAllStudents()
        {
            foreach (Student item in _students)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
