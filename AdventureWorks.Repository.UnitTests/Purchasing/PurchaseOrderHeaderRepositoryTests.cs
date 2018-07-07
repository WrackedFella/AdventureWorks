using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Domain;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using AdventureWorks.Repository.Purchasing.Repositories;
using UnitTests.Core;
using Xunit;

namespace AdventureWorks.Repository.UnitTests.Purchasing
{
	public class PurchaseOrderHeaderRepositoryTests : TestBed
	{
		public AdventureWorksContext BuildContext(params PurchaseOrderHeader[] purchaseOrders)
		{
			var context = GenerateContext();
			if (purchaseOrders.Length == 0)
			{
				return context;
			}

			context.PurchaseOrderHeader.AddRange(purchaseOrders);
			context.SaveChanges();
			return context;
		}

		[Theory]
		[ClassData(typeof(PurchaseOrderTestData))]
		public async Task TestProfileMapping(TestCase<PurchaseOrderHeaderModel> testCase)
		{
			// Arrange
			var data = new[] { (PurchaseOrderHeader)testCase.Data };
			var context = this.BuildContext(data);
			var repo = new PurchaseOrderHeaderRepository(context);

			// Act
			var testResult = await repo.Get(1);

			// Assert
			Assert.NotNull(testResult);
			Assert.Equal(testResult.PurchaseOrderId, testCase.Expected.PurchaseOrderId);
			Assert.Equal(testResult.RevisionNumber, testCase.Expected.RevisionNumber);
			Assert.Equal(testResult.Status, testCase.Expected.Status);
			Assert.Equal(testResult.EmployeeId, testCase.Expected.EmployeeId);
			Assert.Equal(testResult.VendorId, testCase.Expected.VendorId);
			Assert.Equal(testResult.ShipMethodId, testCase.Expected.ShipMethodId);
			Assert.Equal(testResult.OrderDate, testCase.Expected.OrderDate);
			Assert.Equal(testResult.ShipDate, testCase.Expected.ShipDate);
			Assert.Equal(testResult.SubTotal, testCase.Expected.SubTotal);
			Assert.Equal(testResult.TaxAmt, testCase.Expected.TaxAmt);
			Assert.Equal(testResult.Freight, testCase.Expected.Freight);
			Assert.Equal(testResult.TotalDue, testCase.Expected.TotalDue);
			Assert.Equal(testResult.VendorDisplayName, testCase.Expected.VendorDisplayName);
			Assert.Equal(testResult.ShipMethodDisplayName, testCase.Expected.ShipMethodDisplayName);
		}
	}
}
