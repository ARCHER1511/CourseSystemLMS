using System;
using System.Collections.Generic;

namespace CourseSystemLMS.ViewModels
{
    public class GroupViewModel
    {
        public int GroupId { get; set; }

        // For Groups Page
        public string Name { get; set; }            // Group name
        public string Grade { get; set; }           // Grade
        public decimal MonthlyPrice { get; set; }   // Price per month
        public string Description { get; set; }     // Optional description

        // For Payments Page
        public List<StudentPaymentViewModel> Students { get; set; } = new List<StudentPaymentViewModel>();
    }

    public class StudentPaymentViewModel
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string ParentContact { get; set; }
        public string Grade { get; set; }
        public string GroupName { get; set; }

        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }

        public string PaymentStatus { get; set; }   // e.g., "Not Paid", "Partial", "Full Paid"
        public string PaymentInfo { get; set; }     // e.g., "500 / 1000 Paid"
    }
}
