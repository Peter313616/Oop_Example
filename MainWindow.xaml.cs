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

namespace oopExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person p1 = new Person("Bob", "Smith", new DateTime(1966, 2, 28));
            lblOputput.Content = p1.FullName;
            lblOputput.Content += "\n" + p1.getAge();
            Person p2 = new Person("Suzy", "Que", DateTime.Now);
            p2.getAge();
        }
    }

    public class Person
    {
        private string mFirstName;
        private string mLastName;
        private DateTime mBirthday;
        public string FullName
        {
            get
            {
                return mFirstName + " " + mLastName;
            }
        }
        /// <summary>
        /// create a person object.
        /// </summary>
        /// <param name="F">First Name</param>
        /// <param name="L">Last Name</param>
        /// <param name="B">Birth Day</param>
        public Person(string F, string L, DateTime B)
        {
            mFirstName = F;
            mLastName = L;
            mBirthday = B;
        }

        /// <summary>
        /// Gets the age of the person.
        /// </summary>
        /// <returns>An integer the shows the persons age</returns>
        public int getAge()
        {
            int age = DateTime.Now.Year - mBirthday.Year;
            return age;
        }
    }
}
