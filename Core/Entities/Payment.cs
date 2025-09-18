using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Payment : BaseEntity
    {
        public string StudentId { get; set; } = string.Empty;
        public Student? Student { get; set; }
        public string GroupId { get; set; } = string.Empty;
        public Group? Group { get; set; }
        public decimal Amount { get; set; }
        public bool IsPartial { get; set; } = false;
        public DateOnly PaymentDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string Description { get; set; } = string.Empty;
    }
}
