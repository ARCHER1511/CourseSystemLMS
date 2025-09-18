using Core.Enums.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Subscription : BaseEntity
    {
        public string StudentId { get; set; } = string.Empty;
        public Student? Student { get; set; }
        public string GroupId { get; set; } = string.Empty;
        public Group? Group { get; set; }
        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now.AddMonths(1));
        public decimal MonthlyFee { get; set; }
        public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Inactive;
    }
}
