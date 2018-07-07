using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Core
{
	public abstract class EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string ModifiedBy { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTimeOffset CreatedDate { get; set; }
	}
}
