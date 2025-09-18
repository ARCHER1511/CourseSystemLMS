using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class StudentExamScore : BaseEntity
    {
        public string ExamId { get; set; } = string.Empty;
        public Exam? Exam { get; set; }
        public string StudentId { get; set; } = string.Empty;
        public Student? Student { get; set; }
        public decimal Score { get; set; }
    }
}
