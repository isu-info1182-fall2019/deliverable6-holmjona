using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObjects {
    public class Student : Person, ISayTeacher, IComparable<Student> {
        private int _StudentID;

        //private -- Only visible to the class
        //public -- Visible everywhere
        //protected -- visible only to derived classes


        public int StudentID {
            get {
                return _StudentID;
            }
            set {
                if (value > 0) {
                    _StudentID = value;
                }
            }
        }

        public override string SayYourName() {
            return string.Format("Hi, I am {0}!!!", FirstName);
        }

        public override string ToString() {
            return "I am a Student, my name is " + this.FirstName;
        }

        public string SayTeacher() {
            // this.StudentID;
            return "Moo";
        }

        public Student CloneMe() {
            return this;
        }

        public int CompareTo(Student other) {
            // compare myself to another
            return this.FirstName.CompareTo(other.FirstName);

            //Student otherStud = (Student)other;
            //if (this.FirstName[0] > otherStud.FirstName[0])
            //    return 1; // I am bigger
            //else if (this.FirstName[0] < otherStud.FirstName[0])
            //    return -1; // I am smaller
            //else
            //    return 0; // we are the same

        }
    }
}
