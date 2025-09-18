using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Session : BaseEntity
    {
        public string GroupId { get; set; } = string.Empty;
        public Group? Group { get; set; }
        public DateOnly SessionDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
