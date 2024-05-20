using System;
using System.Collections.Generic;

namespace ASPCoreWebApiCRUD.Models
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
        }

        public int DeptId { get; set; }
        public string? DeptName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
