using System;

namespace StudentDiary3.Business
{
    public class University
    {
        public string Name { get; }
        public string Address { get; }
        public string Group { get; }


        public University(string name, string address, string group)
        {
            Name = name;
            Address = address;
            Group = group;
        }

    }
}
