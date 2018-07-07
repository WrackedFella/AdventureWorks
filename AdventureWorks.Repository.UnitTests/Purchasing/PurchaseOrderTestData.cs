using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Domain.HumanResources;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using UnitTests.Core;

namespace AdventureWorks.Repository.UnitTests.Purchasing
{
	public class PurchaseOrderTestData : IEnumerable<object[]>
	{
		// ToDo: Need an Entity, Model combo for the input/output of th test.
		private readonly PurchaseOrderHeader testEntity1 = new PurchaseOrderHeader
		{
			PurchaseOrderId = 1,
			RevisionNumber = 1,
			Status = (int)PurchaseOrderStatus.Open,
			EmployeeId = 1,
			Vendor = new Vendor
			{
				Name = "Initech, Inc"
			},
			ShipMethodId = 1,
			OrderDate = new DateTime(2018, 1, 1),
			ShipDate = new DateTime(2018, 1, 1),
			SubTotal = 1,
			TaxAmt = 1,
			Freight = 1,
			TotalDue = 1,
		};

		private readonly PurchaseOrderHeaderModel testModel1 = new PurchaseOrderHeaderModel
		{
			PurchaseOrderId = 1,
			RevisionNumber = 1,
			Status = (int)PurchaseOrderStatus.Open,
			EmployeeId = 1,
			VendorId = 1,
			ShipMethodId = 1,
			OrderDate = new DateTime(2018, 1, 1),
			ShipDate = new DateTime(2018, 1, 1),
			SubTotal = 1,
			TaxAmt = 1,
			Freight = 1,
			TotalDue = 1,
			VendorDisplayName = "Initech, Inc"
		};

		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", -30)),
					Data = this.testModel1
				}
			};
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", -10)),
					Data = this.testModel1
				}
			};
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", 20)),
					Data = this.testModel1
				}
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
