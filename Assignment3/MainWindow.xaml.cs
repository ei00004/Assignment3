using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;
        public MainWindow()
        {
            InitializeComponent();

            person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 35
            };

            UpdatePerson();
        }

        public void UpdatePerson()
        {
            txtbx_fullNameInput.Text = person.FullName;
            txtbx_ageInput.Text = person.Age.ToString();
            chkbx_isAdultInput.IsChecked = person.IsAdult;
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new();
            editWindow.Person = person;
            bool? result = editWindow.ShowDialog();

            if (result == true)
            {
                person = editWindow.Person;
                UpdatePerson();
            }
        }
    }
}