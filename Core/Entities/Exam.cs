using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Exam : BaseEntity
    {
        public string GradeId { get; set; } = string.Empty;
        public Grade? Grade { get; set; }
        public string GroupId { get; set; } = string.Empty;
        public Group? Group { get; set; }
        public DateOnly ExamDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
