using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary3.Business
{
    public class Semester
    {
        public FirstTrimestr FirstTrimestr { get; }
        public SecondTrimestr SecondTrimestr { get; }
        public ThirdTrimestr ThirdTrimestr { get; }

        public Semester(FirstTrimestr firstTrimestr, SecondTrimestr secondTrimestr, ThirdTrimestr thirdTrimestr)
        {
            FirstTrimestr = firstTrimestr;
            SecondTrimestr = secondTrimestr;
            ThirdTrimestr = thirdTrimestr;
        }
    }
}
