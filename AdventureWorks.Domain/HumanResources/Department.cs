using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.HumanResources
{
    public class Department : EntityBase
    {
        [Key]
        public short DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
    }
}
