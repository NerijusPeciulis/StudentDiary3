using StudentDiary3.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3
{
    public class StudentDiaryGenerate
    {
        public List<string> RetrieveDiaryFormated(List<DiaryReport> diaryReports)
        {

            List<string> data = new List<string>();

            for (int i = 0; i < diaryReports.Count; i++)
            {
                data.Add($"ID: {diaryReports[i].Id}");
                data.Add($"Studento Vardas: {diaryReports[i].Student.Name}");
                data.Add($"Studentas Pavarde: {diaryReports[i].Student.Surname}");
                data.Add($"Studentas Gimimo metai: {diaryReports[i].Student.BirthDate}");
                data.Add($"Studijuoja: {diaryReports[i].University.Name}");
                data.Add($"Adresu: {diaryReports[i].University.Address}");
                data.Add($"Grupeje: {diaryReports[i].University.Group}");
                data.Add($"Pirmo trimestro pazymiu vidurkis: {diaryReports[i].Student.FirstTrimestr}");
                data.Add($"Antro trimestro pazymiu vidurkis: {diaryReports[i].Student.SecondTrimestr}");
                data.Add($"Trecio trimestro pazymiu vidurkis: {diaryReports[i].Student.ThirdTrimestr}");
                data.Add($"---------------------------------");



            }

            return data;
        }


    }
}
