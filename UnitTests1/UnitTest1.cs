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

        [Fact]
        public void IsCalculateAverageInt()
        {


            Random rnd = new Random();
            int grades = rnd.Next(5, 10);
            Random rnd1 = new Random();
            int grades1 = rnd.Next(5, 10);
            Random rnd2 = new Random();
            int grades2 = rnd.Next(5, 10);
            Random rnd3 = new Random();
            int grades3 = rnd.Next(5, 10);
            Random rnd4 = new Random();
            int grades4 = rnd.Next(5, 10);
            Random rnd5 = new Random();
            int grades5 = rnd.Next(5, 10);
            Random rnd6 = new Random();
            int grades6 = rnd.Next(5, 10);

            int average = (grades + grades1 + grades2) / 3;
            int average1 = (grades3 + grades1 + grades5) / 3;
            int average2 = (grades4 + grades6 + grades1) / 3;
            int average3 = (grades + grades2 + grades3) / 3;
            int average4 = (grades4 + grades5 + grades6) / 3;
            int average5 = (grades1 + grades3 + grades4) / 3;




            Assert.True(int average);
        }
    }

}
