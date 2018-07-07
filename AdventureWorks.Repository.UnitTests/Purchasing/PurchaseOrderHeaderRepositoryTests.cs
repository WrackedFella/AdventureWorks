using System;
using System.Collections.Generic;
using System.Text;
using AdventureWorks.Dal;
using AdventureWorks.Dal.Purchasing;
using AdventureWorks.Repository.Purchasing.Repositories;
using UnitTests.Core;

namespace AdventureWorks.Repository.UnitTests.Purchasing
{
	public class PurchaseOrderHeaderRepositoryTests : TestBed
	{
		public AdventureWorksContext BuildContext(params PurchaseOrderHeader[] purchaseOrders)
		{
			if (purchaseOrders.Length == 0)
			{
				purchaseOrders = new[] { new PurchaseOrderHeader { } };
			}

			var context = GenerateContext();
			context.PurchaseOrderHeader.AddRange(purchaseOrders);
			context.SaveChanges();
			return context;
		}

		public void TestProfileMapping()
		{
			// Arrange
			var context = this.BuildContext();
			var repo = new PurchaseOrderHeaderRepository(context);

			// Act

			// Assert
		}
	}
}
