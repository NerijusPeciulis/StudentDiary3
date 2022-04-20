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



            FirstTrimestr firstTrimestr1 = new FirstTrimestr()


            Semester semester1 = new Semester()
        }
    }
}
