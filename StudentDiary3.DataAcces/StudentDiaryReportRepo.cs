using StudentDiary3.Business;
using System;
using System.Collections.Generic;

namespace StudentDiary3.DataAcces
{
    public class StudentDiaryReportRepo
    {
        public List<DiaryReport> diaryReports { get; }

        public StudentDiaryReportRepo()
        {
            diaryReports = new List<DiaryReport>();

            University university1 = new University("Kauno Technologijos Universitetas", "K.Donelaičio g. 73, Kaunas", "NEK-81");
            University university2 = new University("Vilniaus Gedimino technikos universitetas", "Saulėtekio al. 11, Vilnius", "NEK-82");
            University university3 = new University("Klaipėdos universitetas", " H. Manto g. 84, Klaipėda", "NEK-83");
            University university4 = new University("VU Šiaulių akademija", "Vilniaus g. 88, Šiauliai", "NEK-83");
            University university5 = new University("Lietuvos sveikatos mokslų universitetas", "A. Mickevičiaus g. 9, Kaunas, Kaunas", "NEK-84");
            University university6 = new University("Mykolo Romerio universitetas", "Ateities g. 20, Vilnius", "NEK-85");

            Student student1 = new Student("Nerijus", "Peciulis", "2000-11-02");
            Student student2 = new Student("Nerijus", "Peciulis", "2000-11-02");
            Student student3 = new Student("Nerijus", "Peciulis", "2000-11-02");
            Student student4 = new Student("Nerijus", "Peciulis", "2000-11-02");
            Student student5 = new Student("Nerijus", "Peciulis", "2000-11-02");
            Student student6 = new Student("Nerijus", "Peciulis", "2000-11-02");

            Random rnd = new Random();
            int grade = rnd.Next(5, 10);

            FirstTrimestr firstTrimestr1 = new FirstTrimestr(rnd);
            FirstTrimestr firstTrimestr2 = new FirstTrimestr(rnd);
            FirstTrimestr firstTrimestr3 = new FirstTrimestr(rnd);
            FirstTrimestr firstTrimestr4 = new FirstTrimestr(rnd);
            FirstTrimestr firstTrimestr5 = new FirstTrimestr(rnd);
            FirstTrimestr firstTrimestr6 = new FirstTrimestr(rnd);

            SecondTrimestr secondTrimestr1 = new SecondTrimestr(rnd);
            SecondTrimestr secondTrimestr2 = new SecondTrimestr(rnd);
            SecondTrimestr secondTrimestr3 = new SecondTrimestr(rnd);
            SecondTrimestr secondTrimestr4 = new SecondTrimestr(rnd);
            SecondTrimestr secondTrimestr5 = new SecondTrimestr(rnd);
            SecondTrimestr secondTrimestr6 = new SecondTrimestr(rnd);

            ThirdTrimestr thirdTrimestr1 = new ThirdTrimestr(rnd);
            ThirdTrimestr thirdTrimestr2 = new ThirdTrimestr(rnd);
            ThirdTrimestr thirdTrimestr3 = new ThirdTrimestr(rnd);
            ThirdTrimestr thirdTrimestr4 = new ThirdTrimestr(rnd);
            ThirdTrimestr thirdTrimestr5 = new ThirdTrimestr(rnd);
            ThirdTrimestr thirdTrimestr6 = new ThirdTrimestr(rnd);


            Semester semester1 = new Semester(firstTrimestr1, secondTrimestr1, thirdTrimestr1);
            Semester semester2 = new Semester(firstTrimestr2, secondTrimestr2, thirdTrimestr2);
            Semester semester3 = new Semester(firstTrimestr3, secondTrimestr3, thirdTrimestr3);
            Semester semester4 = new Semester(firstTrimestr4, secondTrimestr4, thirdTrimestr4);
            Semester semester5 = new Semester(firstTrimestr5, secondTrimestr5, thirdTrimestr5);
            Semester semester6 = new Semester(firstTrimestr6, secondTrimestr6, thirdTrimestr6);



        }
    }
}
