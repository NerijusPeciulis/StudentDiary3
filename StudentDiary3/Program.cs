using System;

namespace StudentDiary3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReport printReport = new PrintReport();
            printReport.PrintAllReports();
            Console.ReadLine();
        }
    }
}
