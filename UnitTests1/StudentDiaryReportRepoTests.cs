using StudentDiary3.Business;
using StudentDiary3.DataAcces;
using System;
using Xunit;

namespace UnitTests1
{
    public class StudentDiaryReportRepoTests
    {
        
        [Fact]
        public void CalculateAverageShoudReturnCorrectValue()
        {
            var studentDiaryReportRepo = new StudentDiaryReportRepo();

            var average =  studentDiaryReportRepo.CalculateAverage(5, 10, 9);
            var expected = 8;

            Assert.Equal(expected, average);
        }

    }

}
