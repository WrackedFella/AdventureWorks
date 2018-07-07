using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Repository.Purchasing.Models;
using UnitTests.Core;

namespace AdventureWorks.Repository.UnitTests.Purchasing
{
	public class PurchaseOrderTestData : IEnumerable<object[]>
	{
		// ToDo: Need an Entity, Model combo for the input/output of th test.
		private readonly PurchaseOrderHeaderModel _testCase1 = new PurchaseOrderHeaderModel
		{
			PurchaseOrderId = 1,
			RevisionNumber = 1,
			Status = 1,
			EmployeeId = 1,
			VendorId = 1,
			ShipMethodId = 1,
			OrderDate = new DateTime(2018, 1, 1),
			ShipDate = new DateTime(2018, 1, 1),
			SubTotal = 1,
			TaxAmt = 1,
			Freight = 1,
			TotalDue = 1,
			EmployeeDisplayName = "Smith, John",
			VendorDisplayName = "Initech, Inc"
		};

		public IEnumerator<object[]> GetEnumerator()
		{
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", -30)),
					Data = _testCase1
				}
			};
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", -10)),
					Data = _testCase1
				}
			};
			yield return new object[]
			{
				new TestCase {
					Expected = new ExpectedResult(new KeyValuePair<string, int>("Balance", 20)),
					Data = _testCase1
				}
			};
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
