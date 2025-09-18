using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Group : BaseEntity
    {
        public string GradeId { get; set; } = string.Empty;
        public Grade? Grade { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal MonthlyPrice { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

    }
}
