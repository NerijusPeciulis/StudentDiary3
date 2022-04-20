using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3.Business
{
    public class Semester
    {
        public Random FirstTrimestr { get; }
        public Random SecondTrimestr { get; }
        public Random ThirdTrimestr { get; }

        public Semester(Random firstTrimestr, Random secondTrimestr, Random thirdTrimestr)
        {
            FirstTrimestr = firstTrimestr;
            SecondTrimestr = secondTrimestr;
            ThirdTrimestr = thirdTrimestr;
        }
    }
}
