using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3.Business
{
    public class DiaryReport
    {
        public int Id { get; }
        public University University { get; }
        public Student Student { get; }
      

        public DiaryReport(int id, University university, Student student) 
        {
            Id = id;
            University = university;
            Student = student;
           
        }
    }
}
