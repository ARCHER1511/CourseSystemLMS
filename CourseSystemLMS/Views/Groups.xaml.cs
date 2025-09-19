using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CourseSystemLMS.ViewModels;

namespace CourseSystemLMS.Views
{
    public partial class Groups : Page
    {
        private List<GroupViewModel> allGroups;

        public Groups()
        {
            InitializeComponent();
            LoadGroups();
        }

        private void LoadGroups()
        {
            // Dummy data for now
            allGroups = new List<GroupViewModel>
            {
                new GroupViewModel { GroupId = 1, Name = "Group A", Grade = "Grade 6", MonthlyPrice = 500, Description = "Morning group for Grade 6" },
                new GroupViewModel { GroupId = 2, Name = "Group B", Grade = "Grade 5", MonthlyPrice = 450, Description = "Afternoon group for Grade 5" },
                new GroupViewModel { GroupId = 3, Name = "Group C", Grade = "Grade 6", MonthlyPrice = 500, Description = "Evening group for advanced students" }
            };

            GroupsDataGrid.ItemsSource = allGroups;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                GroupsDataGrid.ItemsSource = allGroups;
                return;
            }

            var filtered = allGroups
                .Where(g => g.Name.ToLower().Contains(searchText) || g.Description.ToLower().Contains(searchText))
                .ToList();

            GroupsDataGrid.ItemsSource = filtered;
        }

        private void NewGroup_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddGroupWindow
            {
                Owner = Window.GetWindow(this)
            };

            if (addWindow.ShowDialog() == true)
            {
                // Add the new group
                allGroups.Add(addWindow.NewGroup);

                // Refresh DataGrid
                GroupsDataGrid.ItemsSource = null;
                GroupsDataGrid.ItemsSource = allGroups;

                MessageBox.Show("Group added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

}
