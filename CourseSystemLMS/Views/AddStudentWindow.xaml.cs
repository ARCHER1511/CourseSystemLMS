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

namespace CourseSystemLMS.Views
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public StudentViewModel NewStudent { get; private set; }

        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(FullNameBox.Text) ||
                DOBPicker.SelectedDate == null ||
                string.IsNullOrWhiteSpace(ParentContactBox.Text) ||
                SubscriptionStatusBox.SelectedIndex == -1 || // FIXED HERE
                string.IsNullOrWhiteSpace(GradeBox.Text) ||
                string.IsNullOrWhiteSpace(GroupBox.Text))
            {
                MessageBox.Show("Please fill all fields before adding.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            // Create the new student
            NewStudent = new StudentViewModel
            {
                StudentId = new Random().Next(1000, 9999), // TEMP ID
                FullName = FullNameBox.Text,
                DOB = DOBPicker.SelectedDate.Value.ToShortDateString(),
                ParentContact = ParentContactBox.Text,
                SubscriptionStatus = ((ComboBoxItem)SubscriptionStatusBox.SelectedItem).Content.ToString(),
                CurrentGrade = GradeBox.Text,
                CurrentGroup = GroupBox.Text
            };

            DialogResult = true; // This will close the window and return success
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; // Close without adding
        }
    }
}
