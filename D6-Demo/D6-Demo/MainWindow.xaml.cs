using BaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace D6_Demo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        BaseObjects.
            Room r = new Room();
        public MainWindow() {
            InitializeComponent();
        }

        private void btnBuildStuff_Click(object sender, RoutedEventArgs e) {
            // Look at Arrays vs Lists
            int[] arrInt = new int[2];
            arrInt[0] = 1;
            arrInt[1] = 2;
            //arrInt[2] = "3";

            List<int> lstInt = new List<int>();
            lstInt.Add(1);
            lstInt.Add(2);
            lstInt.Add(3);
            lstInt.Add((int)4.5);
            //lstInt.Add("3");

            List<string> lstString = new List<string>();
            lstString.Add("1");
            lstString.Add("Two");
            //lstString.Add(3.ToString());
            List<Person> lstPeople = new List<Person>();
            lstPeople.Add(new Student());
            lstPeople.Add(new Student());
            lstPeople.Add(new Teacher());

            Student one = (Student)lstPeople[0];
            one.StudentID = 3;



            Person p = new Student();

            List<Student> lstStudent = new List<Student>();
            lstStudent.Add(new Student());
            lstStudent.Add((Student)p);


            // string -> int --- Parse
            // int -> string --- Conversion

            // base -> derived --- Casting
            // unknown -> known --- Casting

            // double -> int --- Casting (shorting, truncating, narrowing)
            // int -> double --- widening, expanding, elevating


            foreach (Student stud in lstStudent) {


            }

            List<List<int>> dblLstInt = new List<List<int>>();
            dblLstInt.Add(new List<int>());
            dblLstInt[0].Add(1);

            Dictionary<Teacher, List<Student>> myClass = new Dictionary<Teacher, List<Student>>();

            Button btn = new Button();
            ISayTeacher ist = new Student();
            Student a = new Student();
            a.SayTeacher();

            r.Students.Add(new Student() { FirstName = "Mary" });

            r.Students.Sort();
            // List out the students
            tbOut.Text = "";
            foreach (Student s in r.Students) {
                tbOut.Text += s.FirstName + "\r\n";
            }

            //var studFound = r.Students.Where(stud => stud.FirstName[1] == 'z');
            //  foreach(Student s in studFound) {
            //      tbOut.Text += s.FirstName;
            //  }

            Teacher mrSmith = new Teacher();
            Student litleJohnny = new Student();

            Desk<Teacher> teachersDesk = new Desk<Teacher>();
            teachersDesk.Sitter = mrSmith;
            //teachersDesk.Sitter = litleJohnny;


            Desk<Person> openDesk = new Desk<Person>();
            openDesk.Sitter = mrSmith;
            openDesk.Sitter = litleJohnny;

            Desk<int> calc = new Desk<int>();
           // calc.Sitter = mrSmith;
            calc.Sitter = 2645;


            StudyGroup<Teacher,Student> sg1 = new StudyGroup<Teacher,Student>();
            StudyGroup<Student,Teacher> sg2 = new StudyGroup<Student,Teacher>();
            StudyGroup<String,Char> sg3 = new StudyGroup<String,Char>();
            //            sg.Leader
            //sg.Members
            int aa = 4;
            sg1.Leader = new Teacher();
            sg2.Leader = new Student();
            sg3.Leader = "string";

            List<int> ints = new List<int>();
            List<char> chars = new List<char>();

        }

        private void btnShowStuff_Click(object sender, RoutedEventArgs e) {
            School.Number = 34;


            frmSecond frm = new frmSecond();
            frm.Show();
            r.SayTeacher();
        }
    }
}
