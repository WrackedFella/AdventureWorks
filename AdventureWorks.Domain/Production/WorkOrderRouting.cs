using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Production
{
    public class WorkOrderRouting : EntityBase
    {
        [Key]
        public int WorkOrderId { get; set; }
        [Key]
        public int ProductId { get; set; }
        [Key]
        public short OperationSequence { get; set; }
        public short LocationId { get; set; }
        public DateTime ScheduledStartDate { get; set; }
        public DateTime ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? ActualResourceHrs { get; set; }
        public decimal PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }

        public virtual Location Location { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
