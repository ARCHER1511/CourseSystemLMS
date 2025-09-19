using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CourseSystemLMS.Views
{
    public partial class Students : Page
    {
        public Students()
        {
            InitializeComponent();
            LoadStudents();
        }

        private List<StudentViewModel> allStudents;

        private void LoadStudents()
        {
            // Dummy data for now
            allStudents = new List<StudentViewModel>
            {
                new StudentViewModel { StudentId = 1, FullName = "Ahmed Ali", DOB = new DateTime(2010, 5, 15).ToShortDateString(), ParentContact = "01012345678", SubscriptionStatus = "Active", CurrentGrade = "Grade 6", CurrentGroup = "Group A" },
                new StudentViewModel { StudentId = 2, FullName = "Mona Hassan", DOB = new DateTime(2011, 8, 20).ToShortDateString(), ParentContact = "01098765432", SubscriptionStatus = "Inactive", CurrentGrade = "Grade 5", CurrentGroup = "Group B" },
                new StudentViewModel { StudentId = 3, FullName = "Ali Ibrahim", DOB = new DateTime(2010, 3, 10).ToShortDateString(), ParentContact = "01122334455", SubscriptionStatus = "Active", CurrentGrade = "Grade 6", CurrentGroup = "Group A" }
            };

            StudentsDataGrid.ItemsSource = allStudents;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                StudentsDataGrid.ItemsSource = allStudents;
                return;
            }

            var filtered = allStudents
                .Where(s => s.FullName.ToLower().Contains(searchText) || s.ParentContact.Contains(searchText))
                .ToList();

            StudentsDataGrid.ItemsSource = filtered;
        }

        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddStudentWindow
            {
                Owner = Window.GetWindow(this) // Sets the parent window
            };

            if (addWindow.ShowDialog() == true)
            {
                // Add the new student to our list
                allStudents.Add(addWindow.NewStudent);

                // Refresh the DataGrid
                StudentsDataGrid.ItemsSource = null;
                StudentsDataGrid.ItemsSource = allStudents;

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

    }

    // Temporary view model class
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string ParentContact { get; set; }
        public string SubscriptionStatus { get; set; }
        public string CurrentGrade { get; set; }
        public string CurrentGroup { get; set; }
    }
}
