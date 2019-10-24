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


            r.Students.Add(new Student() { FirstName = "Mary" });

            //foreach(Student s in r.Students) {
            //    tbOut.Text += s.FirstName;
            //}

          var studFound = r.Students.Where(stud => stud.FirstName[1] == 'z');
            foreach(Student s in studFound) {
                tbOut.Text += s.FirstName;
            }

        }

        private void btnShowStuff_Click(object sender, RoutedEventArgs e) {
            School.Number = 34;


            frmSecond frm = new frmSecond();
            frm.Show();
            r.SayTeacher();
        }
    }
}
