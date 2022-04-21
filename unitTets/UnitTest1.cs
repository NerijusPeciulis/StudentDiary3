using System;
using Xunit;

namespace unitTets
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
        [Fact]
        public void IsCalculateAverageOfTrimestrs()
        {

        }

    }
}
