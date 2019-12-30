using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.HumanResources
{
    public class Department : EntityAuditBase
    {
        [Key]
        public short DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
    }
}
