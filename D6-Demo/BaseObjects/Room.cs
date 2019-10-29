using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObjects {
    public class Room : ISayTeacher
    {
        private int _Number;
        private Teacher _Teacher;
        private List<Student> _Students;

        public int Number {
            get { return _Number; }
            set { _Number = value; }
        }

        public Teacher Teacher {
            get {
                return _Teacher;
            }
            set {
                _Teacher = value;
            }
        }

        public List<Student> Students {
            get {
                if(_Students == null) {
                    fillStudents();
                }
                return _Students;
            }
            set {
                _Students = value;
            }
        }

        private void fillStudents() {
            _Students = new List<Student>();
            _Students.Add(new Student() { FirstName = "Bill" });
            _Students.Add(new Student() { FirstName = "Sally" });
            _Students.Add(new Student() { FirstName = "Meshari" });
            _Students.Add(new Student() { FirstName = "Sushan" });
            _Students.Add(new Student() { FirstName = "Frank" });

        }

        public string SayTeacher()
        {
            return "Boo";
        }

    }



}
