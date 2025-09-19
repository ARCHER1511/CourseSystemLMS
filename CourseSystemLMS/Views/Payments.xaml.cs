using CourseSystemLMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CourseSystemLMS.Views
{
    public partial class Payments : Page
    {
        private List<GroupViewModel> allGroups;

        public Payments()
        {
            InitializeComponent();
            LoadGroups();
        }

        private void LoadGroups()
        {
            // Dummy data
            allGroups = new List<GroupViewModel>
            {
                new GroupViewModel
                {
                    GroupId = 1,
                    Name = "Group A",
                    Students = new List<StudentPaymentViewModel>
                    {
                        new StudentPaymentViewModel
                        {
                            StudentId = 1,
                            FullName = "Ahmed Ali",
                            ParentContact = "01012345678",
                            Grade = "Grade 6",
                            GroupName = "Group A",
                            TotalAmount = 1000,
                            PaidAmount = 1000
                        },
                        new StudentPaymentViewModel
                        {
                            StudentId = 2,
                            FullName = "Mona Hassan",
                            ParentContact = "01098765432",
                            Grade = "Grade 6",
                            GroupName = "Group A",
                            TotalAmount = 1000,
                            PaidAmount = 500
                        },
                        new StudentPaymentViewModel
                        {
                            StudentId = 3,
                            FullName = "Ali Ibrahim",
                            ParentContact = "01122334455",
                            Grade = "Grade 6",
                            GroupName = "Group A",
                            TotalAmount = 1000,
                            PaidAmount = 0
                        }
                    }
                },
                new GroupViewModel
                {
                    GroupId = 2,
                    Name = "Group B",
                    Students = new List<StudentPaymentViewModel>
                    {
                        new StudentPaymentViewModel
                        {
                            StudentId = 4,
                            FullName = "Sara Mohamed",
                            ParentContact = "01234567890",
                            Grade = "Grade 5",
                            GroupName = "Group B",
                            TotalAmount = 800,
                            PaidAmount = 800
                        }
                    }
                }
            };

            GroupsListBox.ItemsSource = allGroups;
        }

        private void GroupsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupsListBox.SelectedItem is GroupViewModel selectedGroup)
            {
                foreach (var student in selectedGroup.Students)
                {
                    if (student.PaidAmount == 0)
                        student.PaymentStatus = "Not Paid";
                    else if (student.PaidAmount < student.TotalAmount)
                        student.PaymentStatus = "Partial";
                    else
                        student.PaymentStatus = "Full Paid";

                    student.PaymentInfo = $"{student.PaidAmount} / {student.TotalAmount} Paid";
                }

                StudentsListView.ItemsSource = selectedGroup.Students;
            }
        }

        private void StudentsListView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (StudentsListView.SelectedItem is StudentPaymentViewModel student)
            {
                var detailsWindow = new PaymentDetailsWindow(student);
                detailsWindow.ShowDialog();
            }
        }
    }

}
