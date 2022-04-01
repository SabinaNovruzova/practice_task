using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (value > 5 || value < 8)
                {
                    StudentLimit = value;
                }
            }
        }
        private Student[] _student = new Student[0];


        public void AddStudent(Student student)
        {
            if (_student.Length < StudentLimit)
            {
                Array.Resize(ref _student, _student.Length + 1);
                _student[_student.Length - 1] = student;
            }
        }
        public bool CheckGroupNo(string GroupNo)
        {
            bool isupper = false;
            bool isdigit = false;
            int upCount = 0;
            int digCount = 0;
            if (GroupNo.Length > 5)
            {
                foreach (var item in GroupNo)
                {
                    if (char.IsUpper(item))
                    {
                        isupper = true;
                        upCount++;
                    }
                    else if (char.IsDigit(item))
                    {
                        isdigit = true;
                        digCount++;
                    }
                }
                if (upCount > 2 && digCount > 3) return true;
            }
            return true;
        }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        public void GetStudent(int id)
        {

        }
        public void GetAllStudents()
        {

        }

        internal void GetAllStudent(object student)
        {
            throw new NotImplementedException();
        }
    }
}

