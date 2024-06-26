﻿using System;
using System.Collections.Generic;

namespace ASPCoreWebApiCRUD.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Fname { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? Description { get; set; }
        public int? DeptId { get; set; }

        public virtual Department? Dept { get; set; }
    }
}
