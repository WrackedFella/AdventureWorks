﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.HumanResources
{
    public class Employee : EntityAuditBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        public string NationalIdNumber { get; set; }
        public string LoginId { get; set; }
        public short? OrganizationLevel { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Person.Person BusinessEntity { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; } = new HashSet<EmployeeDepartmentHistory>();
        public virtual ICollection<EmployeePayHistory> EmployeePayHistory { get; set; } = new HashSet<EmployeePayHistory>();
        public virtual ICollection<JobCandidate> JobCandidate { get; set; } = new HashSet<JobCandidate>();
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
    }
}
