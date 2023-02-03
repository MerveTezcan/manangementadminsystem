using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class merve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InvoiceAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InvoiceMailAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BrandsWebUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ColorBase64Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ColorFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ColorFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCurrencyUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Base64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVatUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductWeightUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWeightUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExplanationWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PurchasePrice = table.Column<int>(type: "int", nullable: true),
                    SalePrice = table.Column<int>(type: "int", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsMixture = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchOffice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InvoiceAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InvoiceMailAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchOffice_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDealer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TaxAdministration = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InvoiceAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    InvoiceMailAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDealer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyDealer_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductProjectId = table.Column<int>(type: "int", nullable: false),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false),
                    ProductCurrencyId = table.Column<int>(type: "int", nullable: false),
                    ProductMeasurementId = table.Column<int>(type: "int", nullable: false),
                    ProductVatId = table.Column<int>(type: "int", nullable: false),
                    ProductWeightId = table.Column<int>(type: "int", nullable: false),
                    ProductImageId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: true),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: true),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductColors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ProductColors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductCurrencyUnits_ProductCurrencyId",
                        column: x => x.ProductCurrencyId,
                        principalTable: "ProductCurrencyUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductMeasurementUnits_ProductMeasurementId",
                        column: x => x.ProductMeasurementId,
                        principalTable: "ProductMeasurementUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductProjects_ProductProjectId",
                        column: x => x.ProductProjectId,
                        principalTable: "ProductProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductVatUnits_ProductVatId",
                        column: x => x.ProductVatId,
                        principalTable: "ProductVatUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductFeatures_ProductWeightUnits_ProductWeightId",
                        column: x => x.ProductWeightId,
                        principalTable: "ProductWeightUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, "Ofis Ürünleri", null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, "Polen Haşere", null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, "İzolasyon", null, null },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, null, "İnşaat", null, null },
                    { 5, null, null, null, null, null, null, null, null, null, null, null, null, "Montaj Asma", null, null },
                    { 6, null, null, null, null, null, null, null, null, null, null, null, null, "Tadilat", null, null },
                    { 7, null, null, null, null, null, null, null, null, null, null, null, null, "Tamir", null, null },
                    { 8, null, null, null, null, null, null, null, null, null, null, null, null, "Maskeleme", null, null },
                    { 9, null, null, null, null, null, null, null, null, null, null, null, null, "Kaydırmaz", null, null },
                    { 10, null, null, null, null, null, null, null, null, null, null, null, null, "İç Cephe Boyalar", null, null },
                    { 11, null, null, null, null, null, null, null, null, null, null, null, null, "Dış Cephe Boyalar", null, null },
                    { 12, null, null, null, null, null, null, null, null, null, null, null, null, "Tinerler", null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "ActiveDateUpdate", "BrandsName", "BrandsWebUrl", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "LogoBase64Content", "LogoFileName", "LogoFilePath", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, "BBBBb", "AAAA", null, null, "dfgvgrfg", null, null, null, null, null, null, null, null, null, null, null, null, "sddsad", null, null });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ActiveDateUpdate", "Code", "ColorBase64Content", "ColorFileName", "ColorFilePath", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "Sarı", null, null });

            migrationBuilder.InsertData(
                table: "ProductCurrencyUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ProductFeaturesId", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, "dfgvgrfg", null, null, null, null, null, null, null, null, null, "BBBBb", 0, "AAAA", null, null });

            migrationBuilder.InsertData(
                table: "ProductMeasurementUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "XXX", "xx", null, null });

            migrationBuilder.InsertData(
                table: "ProductProjects",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "Aaa", null, null, null });

            migrationBuilder.InsertData(
                table: "ProductVatUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "Code", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, "1", null, null, null, null, null, null, null, null, null, null, null, null, "XXX", null, null });

            migrationBuilder.InsertData(
                table: "ProductWeightUnits",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "Explanation", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "ShortCode", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "XXX", "X1", null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActiveDateUpdate", "Barcode", "CategoryId", "Code", "CreateDate", "CreateUserId", "ExpirationDate", "Explanation", "ExplanationWebUrl", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "IsMixture", "LogoBase64Content", "LogoFileName", "LogoFilePath", "Name", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, null, "AS123", 1, "123AS", new DateTime(2022, 12, 14, 15, 0, 46, 761, DateTimeKind.Local).AddTicks(9069), null, new DateTime(2022, 12, 14, 15, 0, 46, 761, DateTimeKind.Local).AddTicks(9061), "hghghggh", "dlld", null, null, null, null, null, null, null, null, null, 0, "ad", "sdf", "sdsdf", "Test Ürün1", 10, 15, 1, "dfsd", new DateTime(2022, 12, 14, 15, 0, 46, 761, DateTimeKind.Local).AddTicks(9070), null });

            migrationBuilder.CreateIndex(
                name: "IX_BranchOffice_CompanyId",
                table: "BranchOffice",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDealer_CompanyId",
                table: "CompanyDealer",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ColorId",
                table: "ProductFeatures",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductBrandId",
                table: "ProductFeatures",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductCurrencyId",
                table: "ProductFeatures",
                column: "ProductCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductImageId",
                table: "ProductFeatures",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductMeasurementId",
                table: "ProductFeatures",
                column: "ProductMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductProjectId",
                table: "ProductFeatures",
                column: "ProductProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductVatId",
                table: "ProductFeatures",
                column: "ProductVatId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductWeightId",
                table: "ProductFeatures",
                column: "ProductWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchOffice");

            migrationBuilder.DropTable(
                name: "CompanyDealer");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductCurrencyUnits");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductMeasurementUnits");

            migrationBuilder.DropTable(
                name: "ProductProjects");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductVatUnits");

            migrationBuilder.DropTable(
                name: "ProductWeightUnits");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
