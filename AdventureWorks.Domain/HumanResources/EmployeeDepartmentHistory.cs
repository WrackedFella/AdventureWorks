using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.HumanResources
{
    public class EmployeeDepartmentHistory : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public short DepartmentId { get; set; }
        [Key]
        public byte ShiftId { get; set; }
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Employee BusinessEntity { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
