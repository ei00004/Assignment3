using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private Person person;

        public Person Person
        {
            get { return person; }
            set
            {
                person = value;

                if (person != null)
                {
                    txtbx_firstNameInput.Text = person.FirstName;
                    txtbx_lastNameInput.Text = person.LastName;
                    txtbx_ageInput.Text = person.Age.ToString();
                }
            }
        }
        public EditWindow()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txtbx_ageInput.Text, out int age))
            {
                Person = new Person
                {
                    FirstName = txtbx_firstNameInput.Text,
                    LastName = txtbx_lastNameInput.Text,
                    Age = age
                };
                DialogResult = true;
            }
            else
            {
                MessageBox.Show(
                    "Please enter a valid age.",
                    "Invalid Age",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
