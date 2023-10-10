using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Domain.System
{
    public class AuditHistory : AutoHistory
    {
        public new DateTime Created { get; set; } = DateTime.Now;
        public string LastModifiedBy { get; set; }

    }
}
