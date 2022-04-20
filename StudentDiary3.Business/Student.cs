using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3.Business
{
    public class Student
    {
        public string Name { get; }
        public string Surname { get; }
        public string BirthDate { get; }


        public Student (string name, string surname, string birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }


    }
}
