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

            Random rnd = new Random();
            int grades = rnd.Next(5, 10);

            Student student1 = new Student("Nerijus", "Peciulis", "2000-11-02", grades, grades, grades);
            Student student2 = new Student("Kristina", "Peciuliene", "2000-10-02", grades, grades, grades);
            Student student3 = new Student("Meda", "Peciulyte", "2000-01-02", grades, grades, grades);
            Student student4 = new Student("Aurimas", "Peciulis", "2000-08-02", grades, grades, grades);
            Student student5 = new Student("Leja", "Peciulyte", "2000-04-02", grades, grades, grades);
            Student student6 = new Student("Austeja", "Peciulyte", "2000-03-02", grades, grades, grades);


            /* Random rnd = new Random();
              int grades = rnd.Next(5, 10);*/



            /* FirstTrimestr firstTrimestr1 = new FirstTrimestr(8);
             FirstTrimestr firstTrimestr2 = new FirstTrimestr(8);
             FirstTrimestr firstTrimestr3 = new FirstTrimestr(8);
             FirstTrimestr firstTrimestr4 = new FirstTrimestr(8);
             FirstTrimestr firstTrimestr5 = new FirstTrimestr(8);
             FirstTrimestr firstTrimestr6 = new FirstTrimestr(8);

             SecondTrimestr secondTrimestr1 = new SecondTrimestr(9);
             SecondTrimestr secondTrimestr2 = new SecondTrimestr(9);
             SecondTrimestr secondTrimestr3 = new SecondTrimestr(9);
             SecondTrimestr secondTrimestr4 = new SecondTrimestr(9);
             SecondTrimestr secondTrimestr5 = new SecondTrimestr(9);
             SecondTrimestr secondTrimestr6 = new SecondTrimestr(9);

             ThirdTrimestr thirdTrimestr1 = new ThirdTrimestr(10);
             ThirdTrimestr thirdTrimestr2 = new ThirdTrimestr(10);
             ThirdTrimestr thirdTrimestr3 = new ThirdTrimestr(10);
             ThirdTrimestr thirdTrimestr4 = new ThirdTrimestr(10);
             ThirdTrimestr thirdTrimestr5 = new ThirdTrimestr(10);
             ThirdTrimestr thirdTrimestr6 = new ThirdTrimestr(10);*/

            /* int average ()
              {
                  double result = (firstTrimestr1 + secondTrimestr1 + thirdTrimestr1) / 3;
                  return Convert.ToInt32(Math.Round(result));
              }*/

            /*  Semester semester1 = new Semester(firstTrimestr1, secondTrimestr1, thirdTrimestr1);
              Semester semester2 = new Semester(firstTrimestr2, secondTrimestr2, thirdTrimestr2);
              Semester semester3 = new Semester(firstTrimestr3, secondTrimestr3, thirdTrimestr3);
              Semester semester4 = new Semester(firstTrimestr4, secondTrimestr4, thirdTrimestr4);
              Semester semester5 = new Semester(firstTrimestr5, secondTrimestr5, thirdTrimestr5);
              Semester semester6 = new Semester(firstTrimestr6, secondTrimestr6, thirdTrimestr6);*/

            diaryReports.Add(new DiaryReport(1, university1, student1));   // , semester1));
            diaryReports.Add(new DiaryReport(2, university2, student2));   //, semester2));
            diaryReports.Add(new DiaryReport(3, university3, student3)); // , semester3));
            diaryReports.Add(new DiaryReport(4, university4, student4));   // , semester4)); 
            diaryReports.Add(new DiaryReport(5, university5, student5));    //, semester5));
            diaryReports.Add(new DiaryReport(6, university6, student6));  // , semester6));

        }

        public List<DiaryReport> Retrieve()
        {
            return diaryReports;
        }

        public DiaryReport Retrieve(int number)
        {
            return diaryReports[number];
        }

    }
}
