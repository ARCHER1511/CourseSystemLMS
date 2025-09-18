using Core.Enums.ValueObjects;
using Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student : BaseEntity
    {
        public string PublicCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string PersonalPhoneNumber { get; set; } = string.Empty;
        public string ParentPhoneNumber { get; set; } = string.Empty;
        public SubscriptionStatus SubscriptionStatus { get; set; } = SubscriptionStatus.Inactive;
        public string CurrentGradeId { get; set; } = string.Empty;
        public Grade? CurrentGrade { get; set; }
        public string CurrentGroupId { get; set; } = string.Empty;
        public Group? CurrentGroup { get; set; }
        public Student() 
        {
            PublicCode = PublicCodeCreate.GeneratePublicCode();
        }

    }
}
