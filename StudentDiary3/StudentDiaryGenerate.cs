using StudentDiary3.Business;
using System;
using System.Collections.Generic;
using System.IO;
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
                data.Add($"     ID: {diaryReports[i].Id}");
                data.Add($"     Studento Vardas: {diaryReports[i].Student.Name}");
                data.Add($"     Studento Pavarde: {diaryReports[i].Student.Surname}");
                data.Add($"     Studento Gimimo metai: {diaryReports[i].Student.BirthDate}");
                data.Add($"     Studijuoja: {diaryReports[i].University.Name}");
                data.Add($"     Adresu: {diaryReports[i].University.Address}");
                data.Add($"     Grupeje: {diaryReports[i].University.Group}");
                data.Add($"     Pirmo trimestro pazymiu vidurkis: {diaryReports[i].Student.FirstTrimestr}");
                data.Add($"     Antro trimestro pazymiu vidurkis: {diaryReports[i].Student.SecondTrimestr}");
                data.Add($"     Trecio trimestro pazymiu vidurkis: {diaryReports[i].Student.ThirdTrimestr}");
                data.Add($"     Metinis pazymiu vidurkis: {diaryReports[i].Student.Average}");
                data.Add($"     -------------------------------");


                var filename = "ataskaita.txt";
                var path = @$"C:\Users\Nerijaus\Desktop\StudentDiary3\StudentDiary3\{filename}";
                File.WriteAllLines(path, data);
;
            }

            return data;
        }


    }
}
