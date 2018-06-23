﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public partial class Illustration
	{
		public int IllustrationId { get; set; }
		public string Diagram { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; } = new HashSet<ProductModelIllustration>();
	}
}
