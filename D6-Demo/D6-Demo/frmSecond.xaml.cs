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
using System.Windows.Shapes;
using BaseObjects;

namespace D6_Demo {
    /// <summary>
    /// Interaction logic for frmSecond.xaml
    /// </summary>
    public partial class frmSecond : Window {
        public frmSecond() {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(School.Number.ToString());

            List<int> ints = new List<int>();
            ints.Add(7);
            ints.Add(21);
            ints.Add(6);
            ints.Add(5);
            ints.Add(14);
            ints.Add(71);
            ints.Add(28);
            ints.Add(76);

            int max = ints.Max();
            int min = ints.Min(x => x);
            double avg = ints.Average();



        }

        private void btnChangeStatic_Click(object sender, RoutedEventArgs e) {
            School.Number += 4;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void btnShutDown_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
