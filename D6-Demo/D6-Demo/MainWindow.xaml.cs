using BaseObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using System.Xml.Serialization;

namespace D6_Demo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        BaseObjects.
            Room r = new Room();
        Student stu;
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


            StudyGroup<Teacher, Student> sg1 = new StudyGroup<Teacher, Student>();
            StudyGroup<Student, Teacher> sg2 = new StudyGroup<Student, Teacher>();
            StudyGroup<String, Char> sg3 = new StudyGroup<String, Char>();
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

        private void btnSerialize_Click(object sender, RoutedEventArgs e) {
            //stu = new Student();
            //stu.FirstName = txtFirstName.Text;
            //stu.LastName = "Karki";
            //stu.StudentID = 92374325;
            //stu.MiddleName = "Raj";

            // XML -- But you cannot do this for your deliverable. 
            //XmlSerializer xmlS = new XmlSerializer(typeof(Student));
            //StreamWriter toFile = new StreamWriter("exampleFileHandling.xml");
            //xmlS.Serialize(toFile, stu);
            //toFile.Close();

            //BinaryFormatter bForm = new BinaryFormatter();
            //FileStream fStream = new FileStream("fileName.student", FileMode.OpenOrCreate);
            //bForm.Serialize(fStream, stu);
            //fStream.Close();

            r = new Room();

            BinaryFormatter bForm = new BinaryFormatter();
            FileStream fStream = new FileStream("my.room", FileMode.OpenOrCreate);
            bForm.Serialize(fStream, r);
            fStream.Close();
        }
        private void btnRead_Click(object sender, RoutedEventArgs e) {

            //FileStream fStream = new FileStream("fileName.student", FileMode.Open);
            //BinaryFormatter bForm = new BinaryFormatter();
            //object o = bForm.Deserialize(fStream);
            //stu = (Student)o;

            //tbSaved.Text = stu.ToString();


            FileStream fStream = new FileStream("my.room", FileMode.Open);
            BinaryFormatter bForm = new BinaryFormatter();
            object o = bForm.Deserialize(fStream);
            fStream.Close();

        }

        private void btnWorkingWithLists_Click(object sender, RoutedEventArgs e) {

            Room r = new Room();
            r.Students = new List<Student>();
            List<Student> studs = new List<Student>();

            studs.Add(new Student() { FirstName = "Boo" });
            r.Students.Add(new Student() { FirstName = "Boo" });
            r.Students.Add(new Student() { FirstName = "Sushan" });
            r.Students.Add(new Student() { FirstName = "Meshari" });

            int counter = 1;
            foreach (Student stud in r.Students) {
                // what am I going to do for each student
                tbOut.Text += counter + ". ";
                tbOut.Text += stud.FirstName;
                tbOut.Text += stud.LastName;
                tbOut.Text += stud.MiddleName;
                counter++;
                tbOut.Text += "\r\n";

            }

            for (int sndx = 0; sndx < r.Students.Count; sndx++) {
                Student stud = r.Students[sndx];
                tbOut.Text += (sndx + 1) + ". ";
                tbOut.Text += stud.FirstName;
                tbOut.Text += stud.LastName;
                tbOut.Text += stud.MiddleName;
                tbOut.Text += "\r\n";
            }


            Teacher t = new Teacher();
            t.Room = r;
            r.Teacher = t;


            List<Student> lst = t.Room.Teacher.Room.Teacher.Room.Students;


            List<int> numbs = new List<int>() { 2, 4, 6, 8, 10, 12 };

            int sum = 0;

            for (int ndx = 0; ndx < numbs.Count; ndx++) {
                sum += numbs[ndx];
            }
            sum = 0;

            foreach (int numb in numbs) {
                sum += numb;
            }



        }

        private void btnBlowUp_Click(object sender, RoutedEventArgs e) {

            //      try { 
            //double x = 200005.5;
            //double y = 2506700;
            //int k = 0;
            //int p = 0;
            //double z = y / k;
            //try {
            //    p = 45 / k;
            //} catch (DivideByZeroException zex) {
            //    p = 45;
            //} catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
            //MessageBox.Show(p.ToString());
            ////MessageBox.Show(ASCIIEncoding.ASCII.GetBytes(z.ToString())[0].ToString());

            //MessageBox.Show(((char)8734).ToString());

            //int big = int.MaxValue;

            //MessageBox.Show((big).ToString());
            // MessageBox.Show((big + 1).ToString());

            //try {
            //    File.ReadAllLines(txtFileName.Text);
            //} catch (ArgumentException aex) {
            //    MessageBox.Show("I am not sure of your name. " +
            //        "Please enter a file name.");
            //    //MessageBox.Show("oops, I had an arguement Exception");
            //} catch (FileNotFoundException fex) {
            //    MessageBox.Show("I am sorry, I could not find that file." +
            //        " Please try another one.");
            //} catch (Exception ex) {
            //    MessageBox.Show("hmm, I had a(n) " + ex.GetType());
            //} finally {
            //    MessageBox.Show("I am in the Finally");
            //}
            try {
                //fuzzyWuzzy(1, 2);
                magicBeans();
            } catch (NotImplementedException nex) {
                MessageBox.Show("Oops, I did not do that yet.");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void fuzzyWuzzy(int val1, int val2) {
            //TODO: need to code this
            throw new NotImplementedException();
        }
        private void magicBeans() {
            throw new Exception("I am in Magic Beans");
        }

        private void btnRecursive_Click(object sender, RoutedEventArgs e) {
            // recursive function is a function that calls itself.
            int num1, num2;
            try {
                num1 = int.Parse(txtNumb1.Text);
                num2 = int.Parse(txtNumb2.Text);

                //while (num2 > 0) {
                //    //num1 += 1000;
                //    num1++;
                //    num2--;
                //}
                int ans = addNumbers(num1, num2);

                tbRecursOut.Text = string.Format("num1: {0}\r\nnum2: {1}\r\nans: {2}",
                    num1, num2, ans);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //private int addNumbers(int n1, int n2) {
        //    while (n2 > 0) {
        //        n1++;
        //        n2--;
        //    }
        //    return n1;
        //}
        //private int addNumbers( int n1,int n2) {
        //    if (n2 > 0)                 {
        //        // keep running
        //        n1++;
        //        n2--;
        //     return addNumbers( n1, n2);
        //    } else {
        //        // stop it
        //    }
        //    return n1;
        //}

        private int addNumbers(int n1, int n2) {
            if (n2 == 0) return n1;
            // keep running
            return addNumbers(n1++, n2--);

        }

        private Person GetFriend(Person p) {
            if (p.Friend == null) return p;
            return GetFriend(p.Friend);
        }

    }
}
