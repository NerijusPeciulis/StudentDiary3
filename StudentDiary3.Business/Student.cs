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
        public int FirstTrimestr { get; }
        public int SecondTrimestr { get; }
        public int ThirdTrimestr { get; }


        public Student (string name, string surname, string birthDate, int firstTrimestr, int secondTrimestr, int thirdTrimestr)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            FirstTrimestr = firstTrimestr;
            SecondTrimestr = secondTrimestr;
            ThirdTrimestr = thirdTrimestr;
        }


    }
}
