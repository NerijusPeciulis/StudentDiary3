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
            University university5 = new University("Lietuvos sveikatos mokslų universitetas", "A. Mickevičiaus g. 9, Kaunas", "NEK-84");
            University university6 = new University("Mykolo Romerio universitetas", "Ateities g. 20, Vilnius", "NEK-85");

            Random rnd = new Random();
            int grades = rnd.Next(5, 10);
            int grades1 = rnd.Next(5, 10);
            int grades2 = rnd.Next(5, 10);
            int grades3 = rnd.Next(5, 10);
            int grades4 = rnd.Next(5, 10);
            int grades5 = rnd.Next(5, 10);
            int grades6 = rnd.Next(5, 10);

            int average = (grades + grades1 + grades2) / 3;
            int average1 = (grades3 + grades1 + grades5) / 3;
            int average2 = (grades4 + grades6 + grades1) / 3;
            int average3 = (grades + grades2 + grades3) / 3;
            int average4 = (grades4 + grades5 + grades6) / 3;
            int average5 = (grades1 + grades3 + grades4) / 3;

            Student student1 = new Student("Nerijus", "Peciulis", "2000-11-02", grades, grades1, grades2, average);
            Student student2 = new Student("Kristina", "Peciuliene", "2000-10-02", grades3, grades1, grades5, average1);
            Student student3 = new Student("Meda", "Peciulyte", "2000-01-02", grades4, grades6, grades1, average2);
            Student student4 = new Student("Aurimas", "Peciulis", "2000-08-02", grades, grades2, grades3, average3);
            Student student5 = new Student("Leja", "Peciulyte", "2000-04-02", grades4, grades5, grades6, average4);
            Student student6 = new Student("Austeja", "Peciulyte", "2000-03-02", grades1, grades3, grades4, average5);

            


            diaryReports.Add(new DiaryReport(1, university1, student1));  
            diaryReports.Add(new DiaryReport(2, university2, student2));   
            diaryReports.Add(new DiaryReport(3, university3, student3)); 
            diaryReports.Add(new DiaryReport(4, university4, student4));   
            diaryReports.Add(new DiaryReport(5, university5, student5));    
            diaryReports.Add(new DiaryReport(6, university6, student6));  

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
