using System;
using System.Collections.Generic;

namespace FileSorter
{
	public class FileSorter
	{
		static void Main()
		{
			var sourceFolder = "D:\\temp";
			var dbo = new [] { "AWBuildVersion", "DatabaseLog", "ErrorLog" };
			var schemasAndTables = new Dictionary<string, string[]>
			{
				{
					"HumanResources",
					new[]
					{
						"Department", "Employee", "EmployeeDepartmentHistory", "EmployeePayHistory", "JobCandidate",
						"Shift"
					}
				},
				{
					"Person",
					new[]
					{
						"Address", "AddressType", "BusinessEntity", "BusinessEntityAddress", "BusinessEntityContact",
						"ContactType", "CountryRegion", "EmailAddress", "Password", "Person", "PersonPhone",
						"PhoneNumberType", "StateProvince"
					}
				},
				{
					"Production",
					new[]
					{
						"BillOfMaterials", "Culture", "Document", "Illustration", "Location", "Product",
						"ProductCategory", "ProductCostHistory", "ProductDescription", "ProductDocument",
						"ProductInventory", "ProductListPriceHistory", "ProductModel", "ProductModelIllustration",
						"ProductModelProductDescriptionCulture", "ProductPhoto", "ProductProductPhoto", "ProductReview",
						"ProductSubcategory", "ScrapReason", "TransactionHistory", "TransactionHistoryArchive",
						"UnitMeasure", "WorkOrder", "WorkOrderRouting"
					}
				},
				{
					"Purchasing",
					new[] {"ProductVendor", "PurchaseOrderDetail", "PurchaseOrderHeader", "ShipMethod", "Vendor"}
				},
				{
					"Sales",
					new[]
					{
						"CountryRegionCurrency", "CreditCard", "Currency", "CurrencyRate", "Customer",
						"PersonCreditCard", "SalesOrderDetail", "SalesOrderHeader", "SalesOrderHeaderSalesReason",
						"SalesPerson", "SalesPersonQuotaHistory", "SalesReason", "SalesTaxRate", "SalesTerritory",
						"SalesTerritoryHistory", "ShoppingCartItem", "SpecialOffer", "SpecialOfferProduct", "Store"
					}
				}
			};

			foreach (var schema in schemasAndTables)
			{
				var targetPath = $"{sourceFolder}\\{schema.Key}";
				if (!System.IO.Directory.Exists(targetPath))
				{
					System.IO.Directory.CreateDirectory(targetPath);
				}
				foreach(var table in schema.Value)
				{
					var sourceFile = $"{sourceFolder}\\{table}.cs";
					if (System.IO.File.Exists(sourceFile))
					{
						System.IO.File.Copy(sourceFile, $"{targetPath}\\{table}.cs", true);
						System.IO.File.Delete(sourceFile);
					}
				}
			}
		}			   
	}				   
}
