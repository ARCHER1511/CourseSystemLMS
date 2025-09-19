using CourseSystemLMS.ViewModels;
using System;
using System.Windows;

namespace CourseSystemLMS.Views
{
    public partial class PaymentDetailsWindow : Window
    {
        public PaymentDetailsWindow(StudentPaymentViewModel student)
        {
            InitializeComponent();

            StudentName.Text = $"Name: {student.FullName}";
            ParentContact.Text = $"Parent Contact: {student.ParentContact}";
            Grade.Text = $"Grade: {student.Grade}";
            GroupName.Text = $"Group: {student.GroupName}";
            TotalAmount.Text = $"Total Amount: {student.TotalAmount}";
            PaidAmount.Text = $"Paid Amount: {student.PaidAmount}";
            RemainingAmount.Text = $"Remaining: {student.TotalAmount - student.PaidAmount}";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
