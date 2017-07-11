using System;


namespace Transmax_Programming_Test
{
    public class Student
    {
        private string _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }

        private string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }

        private uint _score;
        public uint Score { get => _score; set => _score = value; }

        public Student(string lname, string fname, uint score)
        {
            _firstName = fname;
            _lastName = lname;
            _score = score;

        }

        public override string ToString()
        {
            return $"{_lastName},{_firstName},{_score}";
        }

    }
}
