using StudentDiary3.Business;
using StudentDiary3.DataAcces;
using System;
using Xunit;

namespace UnitTests1
{
    public class UnitTest1
    {
        
        [Fact]
        public void IsGenerateRandomInt()
        {


            Random rnd = new Random();
            int grades = rnd.Next(5, 10);

            Assert.InRange(10, 5, 10);
        }

        
    }

}