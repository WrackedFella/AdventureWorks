using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AdventureWorks.Domain.HumanResources;
using AdventureWorks.Domain.Person;
using AdventureWorks.Domain.Production;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Domain.Sales;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Domain
{
	public class AdventureWorksContext : DbContext
	{
		public AdventureWorksContext() { }
		public AdventureWorksContext(DbContextOptions options)
			: base(options) { }

		#region HR
		public virtual DbSet<Department> Department { get; set; }
		public virtual DbSet<Employee> Employee { get; set; }
		public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
		public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
		public virtual DbSet<JobCandidate> JobCandidate { get; set; }
		public virtual DbSet<Shift> Shift { get; set; }
		#endregion

		#region Person
		public virtual DbSet<Address> Address { get; set; }
		public virtual DbSet<AddressType> AddressType { get; set; }
		public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
		public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
		public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
		public virtual DbSet<ContactType> ContactType { get; set; }
		public virtual DbSet<CountryRegion> CountryRegion { get; set; }
		public virtual DbSet<EmailAddress> EmailAddress { get; set; }
		public virtual DbSet<Password> Password { get; set; }
		public virtual DbSet<Person.Person> Person { get; set; }
		public virtual DbSet<PersonPhone> PersonPhone { get; set; }
		public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
		public virtual DbSet<StateProvince> StateProvince { get; set; }
		#endregion

		#region Production
		public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
		public virtual DbSet<Culture> Culture { get; set; }
		public virtual DbSet<Illustration> Illustration { get; set; }
		public virtual DbSet<Location> Location { get; set; }
		public virtual DbSet<Product> Product { get; set; }
		public virtual DbSet<ProductCategory> ProductCategory { get; set; }
		public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
		public virtual DbSet<ProductDescription> ProductDescription { get; set; }
		public virtual DbSet<ProductInventory> ProductInventory { get; set; }
		public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
		public virtual DbSet<ProductModel> ProductModel { get; set; }
		public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
		public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
		public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
		public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
		public virtual DbSet<ProductReview> ProductReview { get; set; }
		public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
		public virtual DbSet<ScrapReason> ScrapReason { get; set; }
		public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
		public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
		public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
		public virtual DbSet<WorkOrder> WorkOrder { get; set; }
		public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
		#endregion

		#region Purchasing
		public virtual DbSet<ProductVendor> ProductVendor { get; set; }
		public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
		public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
		public virtual DbSet<ShipMethod> ShipMethod { get; set; }
		public virtual DbSet<Vendor> Vendor { get; set; }
		#endregion

		#region Sales
		public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
		public virtual DbSet<CreditCard> CreditCard { get; set; }
		public virtual DbSet<Currency> Currency { get; set; }
		public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
		public virtual DbSet<Customer> Customer { get; set; }
		public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
		public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
		public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
		public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
		public virtual DbSet<SalesPerson> SalesPerson { get; set; }
		public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
		public virtual DbSet<SalesReason> SalesReason { get; set; }
		public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
		public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
		public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
		public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
		public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
		public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
		public virtual DbSet<Store> Store { get; set; }
		#endregion

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=.;Initial Catalog=AdventureWorks_Dev;Integrated Security=True");
			}

#if DEBUG
			optionsBuilder.EnableSensitiveDataLogging();
#endif
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			foreach (var et in modelBuilder.Model.GetEntityTypes())
			{
				var props = et.GetProperties().Where(p => p.IsKey()).ToArray();
				if (props.Length == 1)
				{
					var uid = props[0];

					if (uid != null && uid.ClrType == typeof(Guid))
					{
						uid.SetDefaultValueSql("(newid())");
					}
				}

				foreach (var dateProp in et.GetProperties().Where(p => p.ClrType == typeof(DateTime)))
				{
					dateProp.SetDefaultValueSql("(getdate())");
				}

				foreach (var decimalProp in et.GetProperties().Where(p => p.ClrType == typeof(decimal)))
				{
					decimalProp.SetColumnType("decimal(18, 6)");
				}
				var nameParts = et.Name.Split('.');
				var schemaName = "dbo";
				if(nameParts?.Length > 3)
				{
					var index = nameParts.Length - 2;
					schemaName = nameParts[index];
				}
				et.SetSchema(schemaName);
			}

			modelBuilder.Entity<SalesOrderHeader>()
				.HasOne(x => x.BillToAddress)
				.WithMany(x => x.SalesOrderHeaderBillToAddress);
			modelBuilder.Entity<SalesOrderHeader>()
				.HasOne(x => x.ShipToAddress)
				.WithMany(x => x.SalesOrderHeaderShipToAddress);

			modelBuilder.Entity<BillOfMaterials>()
				.HasOne(x => x.Component)
				.WithMany(x => x.BillOfMaterialsComponent);
			modelBuilder.Entity<BillOfMaterials>()
				.HasOne(x => x.ProductAssembly)
				.WithMany(x => x.BillOfMaterialsProductAssembly);

			modelBuilder.Entity<Product>()
				.HasOne(x => x.SizeUnitMeasureCodeNavigation)
				.WithMany(x => x.ProductSizeUnitMeasureCodeNavigation);
			modelBuilder.Entity<Product>()
				.HasOne(x => x.WeightUnitMeasureCodeNavigation)
				.WithMany(x => x.ProductWeightUnitMeasureCodeNavigation);

			modelBuilder.Entity<Currency>()
				.HasMany(x => x.CurrencyRateFromCurrencyCodeNavigation)
				.WithOne(x => x.FromCurrencyCodeNavigation);
			modelBuilder.Entity<Currency>()
				.HasMany(x => x.CurrencyRateToCurrencyCodeNavigation)
				.WithOne(x => x.ToCurrencyCodeNavigation);


			modelBuilder.Entity<BusinessEntityAddress>().HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });
			modelBuilder.Entity<BusinessEntityContact>().HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });
			modelBuilder.Entity<CountryRegionCurrency>().HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });
			modelBuilder.Entity<EmailAddress>().HasKey(x => new { x.BusinessEntityId, x.EmailAddressId });
			modelBuilder.Entity<EmployeeDepartmentHistory>().HasKey(x => new { x.BusinessEntityId, x.DepartmentId, x.ShiftId, x.StartDate });
			modelBuilder.Entity<EmployeePayHistory>().HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });
			modelBuilder.Entity<PersonCreditCard>().HasKey(x => new { x.BusinessEntityId, x.CreditCardId });
			modelBuilder.Entity<PersonPhone>().HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });
			modelBuilder.Entity<ProductCostHistory>().HasKey(x => new { x.ProductId, x.StartDate });
			modelBuilder.Entity<ProductInventory>().HasKey(x => new { x.ProductId, x.LocationId });
			modelBuilder.Entity<ProductListPriceHistory>().HasKey(x => new { x.ProductId, x.StartDate });
			modelBuilder.Entity<ProductModelIllustration>().HasKey(x => new { x.ProductModelId, x.IllustrationId });
			modelBuilder.Entity<ProductModelProductDescriptionCulture>().HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });
			modelBuilder.Entity<ProductProductPhoto>().HasKey(x => new { x.ProductId, x.ProductPhotoId });
			modelBuilder.Entity<ProductVendor>().HasKey(x => new { x.ProductId, x.BusinessEntityId });
			modelBuilder.Entity<PurchaseOrderDetail>().HasKey(x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });
			modelBuilder.Entity<SalesOrderDetail>().HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });
			modelBuilder.Entity<SalesOrderHeaderSalesReason>().HasKey(x => new { x.SalesOrderId, x.SalesReasonId });
			modelBuilder.Entity<SalesPersonQuotaHistory>().HasKey(x => new { x.BusinessEntityId, x.QuotaDate });
			modelBuilder.Entity<SalesTerritoryHistory>().HasKey(x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });
			modelBuilder.Entity<SpecialOfferProduct>().HasKey(x => new { x.SpecialOfferId, x.ProductId });
			modelBuilder.Entity<WorkOrderRouting>().HasKey(x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw new InvalidOperationException("You must supply a username for audit purposes.");
		}

		public override int SaveChanges()
		{
			throw new InvalidOperationException("You must supply a username for audit purposes.");
		}
		public async Task<int> SaveChangesAsync(string modifiedBy, CancellationToken cancellationToken = default(CancellationToken))
		{
			SetAuditDetails(modifiedBy);

			int token = await base.SaveChangesAsync(cancellationToken);
			return token;
		}

		public int SaveChanges(string modifiedBy)
		{
			SetAuditDetails(modifiedBy);
			return base.SaveChanges();
		}

		private void SetAuditDetails(string modifiedBy)
		{
			var statesToTrack = new[]
			{
				EntityState.Added, EntityState.Modified, EntityState.Deleted
			};
			foreach (var dbEntityEntry in this.ChangeTracker.Entries<EntityBase>()
				.Where(e => statesToTrack.Contains(e.State)))
			{
				dbEntityEntry.Entity.SetAuditDetails(modifiedBy);
			}
		}
	}
}
