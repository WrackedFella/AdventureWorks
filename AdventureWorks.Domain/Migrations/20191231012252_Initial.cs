using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdventureWorks.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HumanResources");

            migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.EnsureSchema(
                name: "Production");

            migrationBuilder.EnsureSchema(
                name: "Purchasing");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "HumanResources",
                columns: table => new
                {
                    DepartmentId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                schema: "HumanResources",
                columns: table => new
                {
                    ShiftId = table.Column<byte>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                schema: "Person",
                columns: table => new
                {
                    AddressTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.AddressTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEntity",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntity", x => x.BusinessEntityId);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
                schema: "Person",
                columns: table => new
                {
                    ContactTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.ContactTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CountryRegion",
                schema: "Person",
                columns: table => new
                {
                    CountryRegionCode = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryRegion", x => x.CountryRegionCode);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberType",
                schema: "Person",
                columns: table => new
                {
                    PhoneNumberTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberType", x => x.PhoneNumberTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Culture",
                schema: "Production",
                columns: table => new
                {
                    CultureId = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culture", x => x.CultureId);
                });

            migrationBuilder.CreateTable(
                name: "Illustration",
                schema: "Production",
                columns: table => new
                {
                    IllustrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Diagram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illustration", x => x.IllustrationId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "Production",
                columns: table => new
                {
                    LocationId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    CostRate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Availability = table.Column<decimal>(type: "decimal(18, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "Production",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDescription",
                schema: "Production",
                columns: table => new
                {
                    ProductDescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Description = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDescription", x => x.ProductDescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                schema: "Production",
                columns: table => new
                {
                    ProductModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    CatalogDescription = table.Column<string>(nullable: true),
                    Instructions = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.ProductModelId);
                });

            migrationBuilder.CreateTable(
                name: "ProductPhoto",
                schema: "Production",
                columns: table => new
                {
                    ProductPhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ThumbNailPhoto = table.Column<byte[]>(nullable: true),
                    ThumbnailPhotoFileName = table.Column<string>(nullable: true),
                    LargePhoto = table.Column<byte[]>(nullable: true),
                    LargePhotoFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhoto", x => x.ProductPhotoId);
                });

            migrationBuilder.CreateTable(
                name: "ScrapReason",
                schema: "Production",
                columns: table => new
                {
                    ScrapReasonId = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrapReason", x => x.ScrapReasonId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionHistoryArchive",
                schema: "Production",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductId = table.Column<int>(nullable: false),
                    ReferenceOrderId = table.Column<int>(nullable: false),
                    ReferenceOrderLineId = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    TransactionType = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ActualCost = table.Column<decimal>(type: "decimal(18, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistoryArchive", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeasure",
                schema: "Production",
                columns: table => new
                {
                    UnitMeasureCode = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasure", x => x.UnitMeasureCode);
                });

            migrationBuilder.CreateTable(
                name: "ShipMethod",
                schema: "Purchasing",
                columns: table => new
                {
                    ShipMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShipBase = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ShipRate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipMethod", x => x.ShipMethodId);
                });

            migrationBuilder.CreateTable(
                name: "CreditCard",
                schema: "Sales",
                columns: table => new
                {
                    CreditCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CardType = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    ExpMonth = table.Column<byte>(nullable: false),
                    ExpYear = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.CreditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "Sales",
                columns: table => new
                {
                    CurrencyCode = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.CurrencyCode);
                });

            migrationBuilder.CreateTable(
                name: "SalesReason",
                schema: "Sales",
                columns: table => new
                {
                    SalesReasonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    ReasonType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReason", x => x.SalesReasonId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOffer",
                schema: "Sales",
                columns: table => new
                {
                    SpecialOfferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Description = table.Column<string>(nullable: true),
                    DiscountPct = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    MinQty = table.Column<int>(nullable: false),
                    MaxQty = table.Column<int>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffer", x => x.SpecialOfferId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    PersonType = table.Column<string>(nullable: true),
                    NameStyle = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    EmailPromotion = table.Column<int>(nullable: false),
                    AdditionalContactInfo = table.Column<string>(nullable: true),
                    Demographics = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_Person_BusinessEntity_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "Purchasing",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreditRating = table.Column<byte>(nullable: false),
                    PreferredVendorStatus = table.Column<bool>(nullable: true),
                    ActiveFlag = table.Column<bool>(nullable: true),
                    PurchasingWebServiceUrl = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_Vendor_BusinessEntity_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesTerritory",
                schema: "Sales",
                columns: table => new
                {
                    TerritoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    CountryRegionCode = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    SalesYtd = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesLastYear = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    CostYtd = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    CostLastYear = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false),
                    CountryRegionCodeNavigationCountryRegionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritory", x => x.TerritoryId);
                    table.ForeignKey(
                        name: "FK_SalesTerritory_CountryRegion_CountryRegionCodeNavigationCountryRegionCode",
                        column: x => x.CountryRegionCodeNavigationCountryRegionCode,
                        principalSchema: "Person",
                        principalTable: "CountryRegion",
                        principalColumn: "CountryRegionCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubcategory",
                schema: "Production",
                columns: table => new
                {
                    ProductSubcategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubcategory", x => x.ProductSubcategoryId);
                    table.ForeignKey(
                        name: "FK_ProductSubcategory_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "Production",
                        principalTable: "ProductCategory",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductModelIllustration",
                schema: "Production",
                columns: table => new
                {
                    ProductModelId = table.Column<int>(nullable: false),
                    IllustrationId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModelIllustration", x => new { x.ProductModelId, x.IllustrationId });
                    table.ForeignKey(
                        name: "FK_ProductModelIllustration_Illustration_IllustrationId",
                        column: x => x.IllustrationId,
                        principalSchema: "Production",
                        principalTable: "Illustration",
                        principalColumn: "IllustrationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModelIllustration_ProductModel_ProductModelId",
                        column: x => x.ProductModelId,
                        principalSchema: "Production",
                        principalTable: "ProductModel",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductModelProductDescriptionCulture",
                schema: "Production",
                columns: table => new
                {
                    ProductModelId = table.Column<int>(nullable: false),
                    ProductDescriptionId = table.Column<int>(nullable: false),
                    CultureId = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModelProductDescriptionCulture", x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });
                    table.ForeignKey(
                        name: "FK_ProductModelProductDescriptionCulture_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "Production",
                        principalTable: "Culture",
                        principalColumn: "CultureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionId",
                        column: x => x.ProductDescriptionId,
                        principalSchema: "Production",
                        principalTable: "ProductDescription",
                        principalColumn: "ProductDescriptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelId",
                        column: x => x.ProductModelId,
                        principalSchema: "Production",
                        principalTable: "ProductModel",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryRegionCurrency",
                schema: "Sales",
                columns: table => new
                {
                    CountryRegionCode = table.Column<string>(nullable: false),
                    CurrencyCode = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryRegionCurrency", x => new { x.CountryRegionCode, x.CurrencyCode });
                    table.ForeignKey(
                        name: "FK_CountryRegionCurrency_CountryRegion_CountryRegionCode",
                        column: x => x.CountryRegionCode,
                        principalSchema: "Person",
                        principalTable: "CountryRegion",
                        principalColumn: "CountryRegionCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryRegionCurrency_Currency_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalSchema: "Sales",
                        principalTable: "Currency",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyRate",
                schema: "Sales",
                columns: table => new
                {
                    CurrencyRateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CurrencyRateDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    FromCurrencyCode = table.Column<string>(nullable: true),
                    ToCurrencyCode = table.Column<string>(nullable: true),
                    AverageRate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    EndOfDayRate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    FromCurrencyCodeNavigationCurrencyCode = table.Column<string>(nullable: true),
                    ToCurrencyCodeNavigationCurrencyCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRate", x => x.CurrencyRateId);
                    table.ForeignKey(
                        name: "FK_CurrencyRate_Currency_FromCurrencyCodeNavigationCurrencyCode",
                        column: x => x.FromCurrencyCodeNavigationCurrencyCode,
                        principalSchema: "Sales",
                        principalTable: "Currency",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrencyRate_Currency_ToCurrencyCodeNavigationCurrencyCode",
                        column: x => x.ToCurrencyCodeNavigationCurrencyCode,
                        principalSchema: "Sales",
                        principalTable: "Currency",
                        principalColumn: "CurrencyCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "HumanResources",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    NationalIdNumber = table.Column<string>(nullable: true),
                    LoginId = table.Column<string>(nullable: true),
                    OrganizationLevel = table.Column<short>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    MaritalStatus = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    SalariedFlag = table.Column<bool>(nullable: true),
                    VacationHours = table.Column<short>(nullable: false),
                    SickLeaveHours = table.Column<short>(nullable: false),
                    CurrentFlag = table.Column<bool>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_Employee_Person_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEntityContact",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    ContactTypeId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntityContact", x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_BusinessEntity_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalSchema: "Person",
                        principalTable: "ContactType",
                        principalColumn: "ContactTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessEntityContact_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    EmailAddressId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EmailAddress1 = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => new { x.BusinessEntityId, x.EmailAddressId });
                    table.ForeignKey(
                        name: "FK_EmailAddress_Person_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Password",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_Password_Person_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPhone",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    PhoneNumberTypeId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPhone", x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });
                    table.ForeignKey(
                        name: "FK_PersonPhone_Person_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPhone_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Person",
                        principalTable: "PhoneNumberType",
                        principalColumn: "PhoneNumberTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonCreditCard",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    CreditCardId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCreditCard", x => new { x.BusinessEntityId, x.CreditCardId });
                    table.ForeignKey(
                        name: "FK_PersonCreditCard_Person_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonCreditCard_CreditCard_CreditCardId",
                        column: x => x.CreditCardId,
                        principalSchema: "Sales",
                        principalTable: "CreditCard",
                        principalColumn: "CreditCardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateProvince",
                schema: "Person",
                columns: table => new
                {
                    StateProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    StateProvinceCode = table.Column<string>(nullable: true),
                    CountryRegionCode = table.Column<string>(nullable: true),
                    IsOnlyStateProvinceFlag = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TerritoryId = table.Column<int>(nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false),
                    CountryRegionCodeNavigationCountryRegionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateProvince", x => x.StateProvinceId);
                    table.ForeignKey(
                        name: "FK_StateProvince_CountryRegion_CountryRegionCodeNavigationCountryRegionCode",
                        column: x => x.CountryRegionCodeNavigationCountryRegionCode,
                        principalSchema: "Person",
                        principalTable: "CountryRegion",
                        principalColumn: "CountryRegionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateProvince_SalesTerritory_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Production",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    ProductNumber = table.Column<string>(nullable: true),
                    MakeFlag = table.Column<bool>(nullable: true),
                    FinishedGoodsFlag = table.Column<bool>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    SafetyStockLevel = table.Column<short>(nullable: false),
                    ReorderPoint = table.Column<short>(nullable: false),
                    StandardCost = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Size = table.Column<string>(nullable: true),
                    SizeUnitMeasureCode = table.Column<string>(nullable: true),
                    WeightUnitMeasureCode = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    DaysToManufacture = table.Column<int>(nullable: false),
                    ProductLine = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    ProductSubcategoryId = table.Column<int>(nullable: true),
                    ProductModelId = table.Column<int>(nullable: true),
                    SellStartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    SellEndDate = table.Column<DateTime>(nullable: true),
                    DiscontinuedDate = table.Column<DateTime>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false),
                    SizeUnitMeasureCodeNavigationUnitMeasureCode = table.Column<string>(nullable: true),
                    WeightUnitMeasureCodeNavigationUnitMeasureCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_ProductModel_ProductModelId",
                        column: x => x.ProductModelId,
                        principalSchema: "Production",
                        principalTable: "ProductModel",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductSubcategory_ProductSubcategoryId",
                        column: x => x.ProductSubcategoryId,
                        principalSchema: "Production",
                        principalTable: "ProductSubcategory",
                        principalColumn: "ProductSubcategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_UnitMeasure_SizeUnitMeasureCodeNavigationUnitMeasureCode",
                        column: x => x.SizeUnitMeasureCodeNavigationUnitMeasureCode,
                        principalSchema: "Production",
                        principalTable: "UnitMeasure",
                        principalColumn: "UnitMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_UnitMeasure_WeightUnitMeasureCodeNavigationUnitMeasureCode",
                        column: x => x.WeightUnitMeasureCodeNavigationUnitMeasureCode,
                        principalSchema: "Production",
                        principalTable: "UnitMeasure",
                        principalColumn: "UnitMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDepartmentHistory",
                schema: "HumanResources",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<short>(nullable: false),
                    ShiftId = table.Column<byte>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDepartmentHistory", x => new { x.BusinessEntityId, x.DepartmentId, x.ShiftId, x.StartDate });
                    table.ForeignKey(
                        name: "FK_EmployeeDepartmentHistory_Employee_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDepartmentHistory_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HumanResources",
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDepartmentHistory_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalSchema: "HumanResources",
                        principalTable: "Shift",
                        principalColumn: "ShiftId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePayHistory",
                schema: "HumanResources",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    RateChangeDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Rate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    PayFrequency = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePayHistory", x => new { x.BusinessEntityId, x.RateChangeDate });
                    table.ForeignKey(
                        name: "FK_EmployeePayHistory_Employee_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobCandidate",
                schema: "HumanResources",
                columns: table => new
                {
                    JobCandidateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    BusinessEntityId = table.Column<int>(nullable: true),
                    Resume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCandidate", x => x.JobCandidateId);
                    table.ForeignKey(
                        name: "FK_JobCandidate_Employee_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderHeader",
                schema: "Purchasing",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    RevisionNumber = table.Column<byte>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    ShipMethodId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ShipDate = table.Column<DateTime>(nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    TaxAmt = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    TotalDue = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderHeader", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeader_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeader_ShipMethod_ShipMethodId",
                        column: x => x.ShipMethodId,
                        principalSchema: "Purchasing",
                        principalTable: "ShipMethod",
                        principalColumn: "ShipMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeader_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "Purchasing",
                        principalTable: "Vendor",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesPerson",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    TerritoryId = table.Column<int>(nullable: true),
                    SalesQuota = table.Column<decimal>(nullable: true),
                    Bonus = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    CommissionPct = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesYtd = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    SalesLastYear = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPerson", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_SalesPerson_Employee_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "HumanResources",
                        principalTable: "Employee",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesPerson_SalesTerritory_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Person",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StateProvinceId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_StateProvince_StateProvinceId",
                        column: x => x.StateProvinceId,
                        principalSchema: "Person",
                        principalTable: "StateProvince",
                        principalColumn: "StateProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesTaxRate",
                schema: "Sales",
                columns: table => new
                {
                    SalesTaxRateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    StateProvinceId = table.Column<int>(nullable: false),
                    TaxType = table.Column<byte>(nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTaxRate", x => x.SalesTaxRateId);
                    table.ForeignKey(
                        name: "FK_SalesTaxRate_StateProvince_StateProvinceId",
                        column: x => x.StateProvinceId,
                        principalSchema: "Person",
                        principalTable: "StateProvince",
                        principalColumn: "StateProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillOfMaterials",
                schema: "Production",
                columns: table => new
                {
                    BillOfMaterialsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductAssemblyId = table.Column<int>(nullable: true),
                    ComponentId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: true),
                    UnitMeasureCode = table.Column<string>(nullable: true),
                    Bomlevel = table.Column<short>(nullable: false),
                    PerAssemblyQty = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    UnitMeasureCodeNavigationUnitMeasureCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillOfMaterials", x => x.BillOfMaterialsId);
                    table.ForeignKey(
                        name: "FK_BillOfMaterials_Product_ComponentId",
                        column: x => x.ComponentId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillOfMaterials_Product_ProductAssemblyId",
                        column: x => x.ProductAssemblyId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillOfMaterials_UnitMeasure_UnitMeasureCodeNavigationUnitMeasureCode",
                        column: x => x.UnitMeasureCodeNavigationUnitMeasureCode,
                        principalSchema: "Production",
                        principalTable: "UnitMeasure",
                        principalColumn: "UnitMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCostHistory",
                schema: "Production",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    StandardCost = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCostHistory", x => new { x.ProductId, x.StartDate });
                    table.ForeignKey(
                        name: "FK_ProductCostHistory_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventory",
                schema: "Production",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    LocationId = table.Column<short>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Shelf = table.Column<string>(nullable: true),
                    Bin = table.Column<byte>(nullable: false),
                    Quantity = table.Column<short>(nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventory", x => new { x.ProductId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_ProductInventory_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "Production",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInventory_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductListPriceHistory",
                schema: "Production",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ListPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductListPriceHistory", x => new { x.ProductId, x.StartDate });
                    table.ForeignKey(
                        name: "FK_ProductListPriceHistory_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductPhoto",
                schema: "Production",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    ProductPhotoId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Primary = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductPhoto", x => new { x.ProductId, x.ProductPhotoId });
                    table.ForeignKey(
                        name: "FK_ProductProductPhoto_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductPhoto_ProductPhoto_ProductPhotoId",
                        column: x => x.ProductPhotoId,
                        principalSchema: "Production",
                        principalTable: "ProductPhoto",
                        principalColumn: "ProductPhotoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReview",
                schema: "Production",
                columns: table => new
                {
                    ProductReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductId = table.Column<int>(nullable: false),
                    ReviewerName = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EmailAddress = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReview", x => x.ProductReviewId);
                    table.ForeignKey(
                        name: "FK_ProductReview_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionHistory",
                schema: "Production",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductId = table.Column<int>(nullable: false),
                    ReferenceOrderId = table.Column<int>(nullable: false),
                    ReferenceOrderLineId = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    TransactionType = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ActualCost = table.Column<decimal>(type: "decimal(18, 6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistory", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_TransactionHistory_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                schema: "Production",
                columns: table => new
                {
                    WorkOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ProductId = table.Column<int>(nullable: false),
                    OrderQty = table.Column<int>(nullable: false),
                    StockedQty = table.Column<int>(nullable: false),
                    ScrappedQty = table.Column<short>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ScrapReasonId = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.WorkOrderId);
                    table.ForeignKey(
                        name: "FK_WorkOrder_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrder_ScrapReason_ScrapReasonId",
                        column: x => x.ScrapReasonId,
                        principalSchema: "Production",
                        principalTable: "ScrapReason",
                        principalColumn: "ScrapReasonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductVendor",
                schema: "Purchasing",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    AverageLeadTime = table.Column<int>(nullable: false),
                    StandardPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    LastReceiptCost = table.Column<decimal>(nullable: true),
                    LastReceiptDate = table.Column<DateTime>(nullable: true),
                    MinOrderQty = table.Column<int>(nullable: false),
                    MaxOrderQty = table.Column<int>(nullable: false),
                    OnOrderQty = table.Column<int>(nullable: true),
                    UnitMeasureCode = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    UnitMeasureCodeNavigationUnitMeasureCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVendor", x => new { x.ProductId, x.BusinessEntityId });
                    table.ForeignKey(
                        name: "FK_ProductVendor_Vendor_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Purchasing",
                        principalTable: "Vendor",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVendor_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVendor_UnitMeasure_UnitMeasureCodeNavigationUnitMeasureCode",
                        column: x => x.UnitMeasureCodeNavigationUnitMeasureCode,
                        principalSchema: "Production",
                        principalTable: "UnitMeasure",
                        principalColumn: "UnitMeasureCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                schema: "Sales",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOfferProduct",
                schema: "Sales",
                columns: table => new
                {
                    SpecialOfferId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOfferProduct", x => new { x.SpecialOfferId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_SpecialOfferProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialOfferProduct_SpecialOffer_SpecialOfferId",
                        column: x => x.SpecialOfferId,
                        principalSchema: "Sales",
                        principalTable: "SpecialOffer",
                        principalColumn: "SpecialOfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetail",
                schema: "Purchasing",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    PurchaseOrderDetailId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    OrderQty = table.Column<short>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ReceivedQty = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    RejectedQty = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    StockedQty = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetail", x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Production",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalSchema: "Purchasing",
                        principalTable: "PurchaseOrderHeader",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesPersonQuotaHistory",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    QuotaDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    SalesQuota = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPersonQuotaHistory", x => new { x.BusinessEntityId, x.QuotaDate });
                    table.ForeignKey(
                        name: "FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesTerritoryHistory",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    TerritoryId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritoryHistory", x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });
                    table.ForeignKey(
                        name: "FK_SalesTerritoryHistory_SalesPerson_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesTerritoryHistory_SalesTerritory_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                schema: "Sales",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Name = table.Column<string>(nullable: true),
                    SalesPersonId = table.Column<int>(nullable: true),
                    Demographics = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.BusinessEntityId);
                    table.ForeignKey(
                        name: "FK_Store_BusinessEntity_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Store_SalesPerson_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEntityAddress",
                schema: "Person",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    AddressTypeId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntityAddress", x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "Person",
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Person",
                        principalTable: "AddressType",
                        principalColumn: "AddressTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessEntityAddress_BusinessEntity_BusinessEntityId",
                        column: x => x.BusinessEntityId,
                        principalSchema: "Person",
                        principalTable: "BusinessEntity",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderRouting",
                schema: "Production",
                columns: table => new
                {
                    WorkOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OperationSequence = table.Column<short>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    LocationId = table.Column<short>(nullable: false),
                    ScheduledStartDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ScheduledEndDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ActualStartDate = table.Column<DateTime>(nullable: true),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    ActualResourceHrs = table.Column<decimal>(nullable: true),
                    PlannedCost = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    ActualCost = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderRouting", x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });
                    table.ForeignKey(
                        name: "FK_WorkOrderRouting_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "Production",
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrderRouting_WorkOrder_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalSchema: "Production",
                        principalTable: "WorkOrder",
                        principalColumn: "WorkOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "Sales",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    PersonId = table.Column<int>(nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    TerritoryId = table.Column<int>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Person",
                        principalTable: "Person",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Store_StoreId",
                        column: x => x.StoreId,
                        principalSchema: "Sales",
                        principalTable: "Store",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_SalesTerritory_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderHeader",
                schema: "Sales",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    RevisionNumber = table.Column<byte>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    ShipDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    OnlineOrderFlag = table.Column<bool>(nullable: true),
                    SalesOrderNumber = table.Column<string>(nullable: true),
                    PurchaseOrderNumber = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    SalesPersonId = table.Column<int>(nullable: true),
                    TerritoryId = table.Column<int>(nullable: true),
                    BillToAddressId = table.Column<int>(nullable: false),
                    ShipToAddressId = table.Column<int>(nullable: false),
                    ShipMethodId = table.Column<int>(nullable: false),
                    CreditCardId = table.Column<int>(nullable: true),
                    CreditCardApprovalCode = table.Column<string>(nullable: true),
                    CurrencyRateId = table.Column<int>(nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    TaxAmt = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Freight = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    TotalDue = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rowguid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeader", x => x.SalesOrderId);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Address_BillToAddressId",
                        column: x => x.BillToAddressId,
                        principalSchema: "Person",
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_CreditCard_CreditCardId",
                        column: x => x.CreditCardId,
                        principalSchema: "Sales",
                        principalTable: "CreditCard",
                        principalColumn: "CreditCardId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_CurrencyRate_CurrencyRateId",
                        column: x => x.CurrencyRateId,
                        principalSchema: "Sales",
                        principalTable: "CurrencyRate",
                        principalColumn: "CurrencyRateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "Sales",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_SalesPerson_SalesPersonId",
                        column: x => x.SalesPersonId,
                        principalSchema: "Sales",
                        principalTable: "SalesPerson",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_ShipMethod_ShipMethodId",
                        column: x => x.ShipMethodId,
                        principalSchema: "Purchasing",
                        principalTable: "ShipMethod",
                        principalColumn: "ShipMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Address_ShipToAddressId",
                        column: x => x.ShipToAddressId,
                        principalSchema: "Person",
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_SalesTerritory_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "Sales",
                        principalTable: "SalesTerritory",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetail",
                schema: "Sales",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(nullable: false),
                    SalesOrderDetailId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    CarrierTrackingNumber = table.Column<string>(nullable: true),
                    OrderQty = table.Column<short>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    SpecialOfferId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    UnitPriceDiscount = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    Rowguid = table.Column<Guid>(nullable: false),
                    SpecialOfferProductSpecialOfferId = table.Column<int>(nullable: true),
                    SpecialOfferProductProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetail", x => new { x.SalesOrderId, x.SalesOrderDetailId });
                    table.ForeignKey(
                        name: "FK_SalesOrderDetail_SalesOrderHeader_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "Sales",
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferProductSpecialOfferId_SpecialOfferProductProductId",
                        columns: x => new { x.SpecialOfferProductSpecialOfferId, x.SpecialOfferProductProductId },
                        principalSchema: "Sales",
                        principalTable: "SpecialOfferProduct",
                        principalColumns: new[] { "SpecialOfferId", "ProductId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderHeaderSalesReason",
                schema: "Sales",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(nullable: false),
                    SalesReasonId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeaderSalesReason", x => new { x.SalesOrderId, x.SalesReasonId });
                    table.ForeignKey(
                        name: "FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "Sales",
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonId",
                        column: x => x.SalesReasonId,
                        principalSchema: "Sales",
                        principalTable: "SalesReason",
                        principalColumn: "SalesReasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDepartmentHistory_DepartmentId",
                schema: "HumanResources",
                table: "EmployeeDepartmentHistory",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDepartmentHistory_ShiftId",
                schema: "HumanResources",
                table: "EmployeeDepartmentHistory",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCandidate_BusinessEntityId",
                schema: "HumanResources",
                table: "JobCandidate",
                column: "BusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateProvinceId",
                schema: "Person",
                table: "Address",
                column: "StateProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityAddress_AddressId",
                schema: "Person",
                table: "BusinessEntityAddress",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityAddress_AddressTypeId",
                schema: "Person",
                table: "BusinessEntityAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityContact_ContactTypeId",
                schema: "Person",
                table: "BusinessEntityContact",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntityContact_PersonId",
                schema: "Person",
                table: "BusinessEntityContact",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhone_PhoneNumberTypeId",
                schema: "Person",
                table: "PersonPhone",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StateProvince_CountryRegionCodeNavigationCountryRegionCode",
                schema: "Person",
                table: "StateProvince",
                column: "CountryRegionCodeNavigationCountryRegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_StateProvince_TerritoryId",
                schema: "Person",
                table: "StateProvince",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BillOfMaterials_ComponentId",
                schema: "Production",
                table: "BillOfMaterials",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillOfMaterials_ProductAssemblyId",
                schema: "Production",
                table: "BillOfMaterials",
                column: "ProductAssemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_BillOfMaterials_UnitMeasureCodeNavigationUnitMeasureCode",
                schema: "Production",
                table: "BillOfMaterials",
                column: "UnitMeasureCodeNavigationUnitMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductModelId",
                schema: "Production",
                table: "Product",
                column: "ProductModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSubcategoryId",
                schema: "Production",
                table: "Product",
                column: "ProductSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SizeUnitMeasureCodeNavigationUnitMeasureCode",
                schema: "Production",
                table: "Product",
                column: "SizeUnitMeasureCodeNavigationUnitMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WeightUnitMeasureCodeNavigationUnitMeasureCode",
                schema: "Production",
                table: "Product",
                column: "WeightUnitMeasureCodeNavigationUnitMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventory_LocationId",
                schema: "Production",
                table: "ProductInventory",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModelIllustration_IllustrationId",
                schema: "Production",
                table: "ProductModelIllustration",
                column: "IllustrationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModelProductDescriptionCulture_CultureId",
                schema: "Production",
                table: "ProductModelProductDescriptionCulture",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductModelProductDescriptionCulture_ProductDescriptionId",
                schema: "Production",
                table: "ProductModelProductDescriptionCulture",
                column: "ProductDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductPhoto_ProductPhotoId",
                schema: "Production",
                table: "ProductProductPhoto",
                column: "ProductPhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReview_ProductId",
                schema: "Production",
                table: "ProductReview",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubcategory_ProductCategoryId",
                schema: "Production",
                table: "ProductSubcategory",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistory_ProductId",
                schema: "Production",
                table: "TransactionHistory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_ProductId",
                schema: "Production",
                table: "WorkOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_ScrapReasonId",
                schema: "Production",
                table: "WorkOrder",
                column: "ScrapReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrderRouting_LocationId",
                schema: "Production",
                table: "WorkOrderRouting",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVendor_BusinessEntityId",
                schema: "Purchasing",
                table: "ProductVendor",
                column: "BusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVendor_UnitMeasureCodeNavigationUnitMeasureCode",
                schema: "Purchasing",
                table: "ProductVendor",
                column: "UnitMeasureCodeNavigationUnitMeasureCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_ProductId",
                schema: "Purchasing",
                table: "PurchaseOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeader_EmployeeId",
                schema: "Purchasing",
                table: "PurchaseOrderHeader",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeader_ShipMethodId",
                schema: "Purchasing",
                table: "PurchaseOrderHeader",
                column: "ShipMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeader_VendorId",
                schema: "Purchasing",
                table: "PurchaseOrderHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryRegionCurrency_CurrencyCode",
                schema: "Sales",
                table: "CountryRegionCurrency",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRate_FromCurrencyCodeNavigationCurrencyCode",
                schema: "Sales",
                table: "CurrencyRate",
                column: "FromCurrencyCodeNavigationCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyRate_ToCurrencyCodeNavigationCurrencyCode",
                schema: "Sales",
                table: "CurrencyRate",
                column: "ToCurrencyCodeNavigationCurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_PersonId",
                schema: "Sales",
                table: "Customer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StoreId",
                schema: "Sales",
                table: "Customer",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TerritoryId",
                schema: "Sales",
                table: "Customer",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCreditCard_CreditCardId",
                schema: "Sales",
                table: "PersonCreditCard",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetail_SpecialOfferProductSpecialOfferId_SpecialOfferProductProductId",
                schema: "Sales",
                table: "SalesOrderDetail",
                columns: new[] { "SpecialOfferProductSpecialOfferId", "SpecialOfferProductProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_BillToAddressId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "BillToAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CreditCardId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CurrencyRateId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "CurrencyRateId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CustomerId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_SalesPersonId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "SalesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_ShipMethodId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "ShipMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_ShipToAddressId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "ShipToAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_TerritoryId",
                schema: "Sales",
                table: "SalesOrderHeader",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeaderSalesReason_SalesReasonId",
                schema: "Sales",
                table: "SalesOrderHeaderSalesReason",
                column: "SalesReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesPerson_TerritoryId",
                schema: "Sales",
                table: "SalesPerson",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTaxRate_StateProvinceId",
                schema: "Sales",
                table: "SalesTaxRate",
                column: "StateProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTerritory_CountryRegionCodeNavigationCountryRegionCode",
                schema: "Sales",
                table: "SalesTerritory",
                column: "CountryRegionCodeNavigationCountryRegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_SalesTerritoryHistory_TerritoryId",
                schema: "Sales",
                table: "SalesTerritoryHistory",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ProductId",
                schema: "Sales",
                table: "ShoppingCartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialOfferProduct_ProductId",
                schema: "Sales",
                table: "SpecialOfferProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_SalesPersonId",
                schema: "Sales",
                table: "Store",
                column: "SalesPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDepartmentHistory",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "EmployeePayHistory",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "JobCandidate",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "BusinessEntityAddress",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "BusinessEntityContact",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "EmailAddress",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "Password",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "PersonPhone",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "BillOfMaterials",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductCostHistory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductInventory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductListPriceHistory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductModelIllustration",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductModelProductDescriptionCulture",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductProductPhoto",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductReview",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "TransactionHistory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "TransactionHistoryArchive",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "WorkOrderRouting",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductVendor",
                schema: "Purchasing");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetail",
                schema: "Purchasing");

            migrationBuilder.DropTable(
                name: "CountryRegionCurrency",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "PersonCreditCard",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesOrderDetail",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesOrderHeaderSalesReason",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesPersonQuotaHistory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesTaxRate",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesTerritoryHistory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "ShoppingCartItem",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "Shift",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "AddressType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "ContactType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "PhoneNumberType",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "Illustration",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Culture",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductDescription",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductPhoto",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "WorkOrder",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "PurchaseOrderHeader",
                schema: "Purchasing");

            migrationBuilder.DropTable(
                name: "SpecialOfferProduct",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesOrderHeader",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "SalesReason",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "ScrapReason",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "Vendor",
                schema: "Purchasing");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "SpecialOffer",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "CreditCard",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "CurrencyRate",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "ShipMethod",
                schema: "Purchasing");

            migrationBuilder.DropTable(
                name: "ProductModel",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "ProductSubcategory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "UnitMeasure",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "StateProvince",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Store",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "Production");

            migrationBuilder.DropTable(
                name: "SalesPerson",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "HumanResources");

            migrationBuilder.DropTable(
                name: "SalesTerritory",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "CountryRegion",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "BusinessEntity",
                schema: "Person");
        }
    }
}
