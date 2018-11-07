using System.Collections.Generic;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AdventureWorks.Services.Purchasing;
using UnitTests.Core;
using Xunit;

namespace AdventureWorks.Services.UnitTests.Purchasing
{
	public class PurchasingServiceTests : TestBed
	{
		public AdventureWorksContext BuildContext(params PurchaseOrderHeader[] purchaseOrders)
		{
			var context = new AdventureWorksContext(GenerateContextOptions());
			if (purchaseOrders.Length == 0)
			{
				return context;
			}

			context.PurchaseOrderHeader.AddRange(purchaseOrders);
			context.SaveChanges();
			return context;
		}

		[Fact]
		public async Task CreatePurchaseOrder_GivenNewPurchaseOrder_ReturnsInt()
		{
			var context = this.BuildContext();
			var service = new PurchasingService(context);

			IEnumerable<PurchaseOrderHeaderModel> result = await service.CreatePurchaseOrderHeaders(new PurchaseOrderHeaderModel());

			Assert.NotNull(result);
		}
	}
}
