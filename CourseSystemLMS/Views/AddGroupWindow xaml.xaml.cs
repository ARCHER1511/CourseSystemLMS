using CourseSystemLMS.ViewModels;
using System;
using System.Windows;

namespace CourseSystemLMS.Views
{
    public partial class AddGroupWindow : Window
    {
        public GroupViewModel NewGroup { get; private set; }
        public AddGroupWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(GroupNameBox.Text) ||
                string.IsNullOrWhiteSpace(GradeBox.Text) ||
                string.IsNullOrWhiteSpace(MonthlyPriceBox.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!decimal.TryParse(MonthlyPriceBox.Text, out decimal price))
            {
                MessageBox.Show("Monthly price must be a valid number.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create new group
            NewGroup = new GroupViewModel
            {
                GroupId = new Random().Next(1000, 9999), // Temporary ID
                Name = GroupNameBox.Text,
                Grade = GradeBox.Text,
                MonthlyPrice = price,
                Description = DescriptionBox.Text
            };

            DialogResult = true; // Closes window and confirms success
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
