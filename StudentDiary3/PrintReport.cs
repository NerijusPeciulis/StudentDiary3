using StudentDiary3.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3
{
    public class PrintReport
    {
        public StudentDiaryReportRepo studentDiaryReportRepo { get; }
        public StudentDiaryGenerate studentDiaryGenerate { get; }


        public PrintReport()
        {
            studentDiaryReportRepo = new StudentDiaryReportRepo();
            studentDiaryGenerate = new StudentDiaryGenerate();

        }

        public void PrintAllReports()
        {
            List<string> studentsDiaryList = studentDiaryGenerate.RetrieveDiaryFormated(studentDiaryReportRepo.Retrieve());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     Generated Students Diary reports:");
            Console.WriteLine("     ------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < studentsDiaryList.Count; i++)
            {
                Console.WriteLine(studentsDiaryList[i]);
            }
        }

    }
}
