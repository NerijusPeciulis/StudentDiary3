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

            Student student1 = CreateNewStudent("Nerijus", "Peciulis", "2000-11-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());
            Student student2 = CreateNewStudent("Kristina", "Peciuliene", "2000-10-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());
            Student student3 = CreateNewStudent("Meda", "Peciulyte", "2000-01-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());
            Student student4 = CreateNewStudent("Aurimas", "Peciulis", "2000-08-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());
            Student student5 = CreateNewStudent("Leja", "Peciulyte", "2000-04-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());
            Student student6 = CreateNewStudent("Austeja", "Peciulyte", "2000-03-02", GenerateRandomGrade(), GenerateRandomGrade(), GenerateRandomGrade());

            diaryReports.Add(new DiaryReport(1, university1, student1));  
            diaryReports.Add(new DiaryReport(2, university2, student2));   
            diaryReports.Add(new DiaryReport(3, university3, student3)); 
            diaryReports.Add(new DiaryReport(4, university4, student4));   
            diaryReports.Add(new DiaryReport(5, university5, student5));    
            diaryReports.Add(new DiaryReport(6, university6, student6));  

        }
        public int GenerateRandomGrade()
        {
            Random rnd = new Random();
            return rnd.Next(5, 10); 
        }
        public Student CreateNewStudent(string name, string surname, string birthdate, int grade1, int grade2, int grade3)
        {
            var average = CalculateAverage(grade1, grade2, grade3);

            return new Student(name, surname, birthdate, grade1, grade2, grade3, average);
        }

        public int CalculateAverage(int grade1, int grade2, int grade3)
        {
            return (grade1 + grade2 + grade3) / 3;
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
