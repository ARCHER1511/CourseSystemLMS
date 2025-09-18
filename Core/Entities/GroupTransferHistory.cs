using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GroupTransferHistory : BaseEntity
    {
        public string StudentId { get; set; } = string.Empty;
        public Student? Student { get; set; }
        public string FromGroupId { get; set; } = string.Empty;
        public Group? FromGroup { get; set; }
        public string ToGroupId { get; set; } = string.Empty;
        public Group? ToGroup { get; set; }
        public DateOnly TransferDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Reason { get; set; } = string.Empty;
    }
}
