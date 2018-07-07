using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Repository.Purchasing.Models;
using UnitTests.Core;

namespace AdventureWorks.Repository.UnitTests.Purchasing
{
	public class PurchaseOrderTestData : IEnumerable<object[]>
	{
		// ToDo: Need an Entity, Model combo for the input/output of th test.
		private const string VendorName = "Initech, Inc";

		private const string ShipMethodName = "Ground";

		private readonly KeyValuePair<PurchaseOrderHeader, PurchaseOrderHeaderModel> _testCase1 =
			new KeyValuePair<PurchaseOrderHeader, PurchaseOrderHeaderModel>(new PurchaseOrderHeader
			{
				PurchaseOrderId = 1,
				RevisionNumber = 1,
				Status = (int)PurchaseOrderStatus.Open,
				EmployeeId = 1,
				Vendor = new Vendor
				{
					Name = VendorName
				},
				ShipMethod = new ShipMethod
				{
					Name = ShipMethodName
				},
				OrderDate = new DateTime(2018, 1, 1),
				ShipDate = new DateTime(2018, 1, 1),
				SubTotal = 1,
				TaxAmt = 1,
				Freight = 1,
				TotalDue = 1,
			}, new PurchaseOrderHeaderModel
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
				VendorDisplayName = VendorName,
				ShipMethodDisplayName = ShipMethodName
			});

		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[]
			{
				new TestCase<PurchaseOrderHeaderModel> {
					Expected = this._testCase1.Value,
					Data = this._testCase1.Key
				}
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
