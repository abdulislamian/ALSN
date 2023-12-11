using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ALSN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IntialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizationLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalNoOfTranslators = table.Column<int>(type: "int", nullable: true),
                    fullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransOfficeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_TransOfficeId",
                        column: x => x.TransOfficeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentsType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    documentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isFixedPrice = table.Column<bool>(type: "bit", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bankDetails",
                columns: table => new
                {
                    bankDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    BankAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslatorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankDetails", x => x.bankDetailId);
                    table.ForeignKey(
                        name: "FK_bankDetails_AspNetUsers_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discountType = table.Column<int>(type: "int", nullable: false),
                    discountValue = table.Column<int>(type: "int", nullable: false),
                    minimumOrderAmount = table.Column<int>(type: "int", nullable: false),
                    validFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    validTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                    table.ForeignKey(
                        name: "FK_Coupons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    TranslatorsId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_language_AspNetUsers_TranslatorsId",
                        column: x => x.TranslatorsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuestId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_tickets_AspNetUsers_GuestId",
                        column: x => x.GuestId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "translOfficeDetails",
                columns: table => new
                {
                    Detailid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commissionPercentage = table.Column<int>(type: "int", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslOfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_translOfficeDetails", x => x.Detailid);
                    table.ForeignKey(
                        name: "FK_translOfficeDetails_AspNetUsers_TranslOfficeId",
                        column: x => x.TranslOfficeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "translationPrice",
                columns: table => new
                {
                    TranslationPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sourceLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    targetLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    DocTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_translationPrice", x => x.TranslationPriceId);
                    table.ForeignKey(
                        name: "FK_translationPrice_DocumentsType_DocTypeId",
                        column: x => x.DocTypeId,
                        principalTable: "DocumentsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    TranslationRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentRequestTypeId = table.Column<int>(type: "int", nullable: false),
                    ServiceCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsQuotationRequested = table.Column<bool>(type: "bit", nullable: false),
                    IsDiscountRequested = table.Column<bool>(type: "bit", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCheckedOut = table.Column<bool>(type: "bit", nullable: false),
                    IsAmendmentRequested = table.Column<bool>(type: "bit", nullable: false),
                    AmendmentReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmendmentRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordCount = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    RequestTranslationFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ServiceCategoryType = table.Column<int>(type: "int", nullable: false),
                    RequestDeliveryAddresssId = table.Column<int>(type: "int", nullable: false),
                    IsSMSTracking = table.Column<bool>(type: "bit", nullable: false),
                    IsDelivery = table.Column<bool>(type: "bit", nullable: false),
                    IsExtendTimeForValidity = table.Column<bool>(type: "bit", nullable: false),
                    IsCertificationOfDocument = table.Column<bool>(type: "bit", nullable: false),
                    GuestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TranslationPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.TranslationRequestId);
                    table.ForeignKey(
                        name: "FK_Translation_Address_RequestDeliveryAddresssId",
                        column: x => x.RequestDeliveryAddresssId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translation_AspNetUsers_GuestId",
                        column: x => x.GuestId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translation_DocumentsType_DocumentRequestTypeId",
                        column: x => x.DocumentRequestTypeId,
                        principalTable: "DocumentsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Translation_translationPrice_TranslationPriceId",
                        column: x => x.TranslationPriceId,
                        principalTable: "translationPrice",
                        principalColumn: "TranslationPriceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "acceptedOrders",
                columns: table => new
                {
                    AcceptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslationId = table.Column<int>(type: "int", nullable: false),
                    translatorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acceptedOrders", x => x.AcceptId);
                    table.ForeignKey(
                        name: "FK_acceptedOrders_AspNetUsers_translatorId",
                        column: x => x.translatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_acceptedOrders_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    TranslationId = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_feedback_AspNetUsers_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_feedback_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orderAssign",
                columns: table => new
                {
                    assignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TranslationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderAssign", x => x.assignId);
                    table.ForeignKey(
                        name: "FK_orderAssign_AspNetUsers_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orderAssign_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rejectOrder",
                columns: table => new
                {
                    RejectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslationId = table.Column<int>(type: "int", nullable: false),
                    DeclineReasonSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeclineReasonDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rejectOrder", x => x.RejectionId);
                    table.ForeignKey(
                        name: "FK_rejectOrder_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "509b7411-1122-49be-a5d6-e616adaf79cd", 0, "da4d791f-59fd-48f0-92e0-b049a2c4b45a", "03149276066", "ApplicationUser", "sample.applicationuser@example.com", false, "Abdullah Khan", "English", false, null, null, null, "hashed_password_here", null, false, "97837b56-c737-49fc-9537-8da50cf7444c", false, "sample.applicationuser" },
                    { "ac1c3372-432d-41b8-b86a-87feb2cf846a", 0, "5dc4315c-17d2-4ff1-be8b-16fa9d76090e", "03149276066", "Guest", "sample.guest@example.com", false, "Sample Guest", "English", false, null, null, null, "hashed_password_here", null, false, "fe7e087a-9738-4d1e-9639-3289b6815465", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompOwnerName", "CompanyName", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotalNoOfTranslators", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e580075e-6b2c-439a-b164-e001877962d6", 0, "Peshawar", "ABC", "XYZ company", "ad4d7305-6efc-434b-b5e6-207342e0ff29", "03149276066", "TranslOffice", "sample.officer@example.com", false, "Sample Translation Officer", "English", false, null, null, null, "hashed_password_here", null, false, "ec9bbbfe-94da-4848-a0ab-a9ac05b3c4ed", 0, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TransOfficeId", "TwoFactorEnabled", "UserName", "fullAddress" },
                values: new object[] { "0fe6fa9e-152d-49d4-8ba6-ceb6875294f3", 0, "eca1d256-b474-4a5a-9a67-1e428889dff3", "03149276066", "Translators", "sample.translator@example.com", false, "Sample Translator", "English", false, null, null, null, "hashed_password_here", null, false, "4b62674c-bf52-4c15-b07f-4e6e1cbf17b7", "e580075e-6b2c-439a-b164-e001877962d6", false, null, "Xyz Address" });

            migrationBuilder.CreateIndex(
                name: "IX_acceptedOrders_TranslationId",
                table: "acceptedOrders",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_acceptedOrders_translatorId",
                table: "acceptedOrders",
                column: "translatorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TransOfficeId",
                table: "AspNetUsers",
                column: "TransOfficeId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_bankDetails_TranslatorId",
                table: "bankDetails",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_UserId",
                table: "Coupons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_feedback_TranslationId",
                table: "feedback",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_feedback_TranslatorId",
                table: "feedback",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_language_TranslatorsId",
                table: "language",
                column: "TranslatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_orderAssign_TranslationId",
                table: "orderAssign",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_orderAssign_TranslatorId",
                table: "orderAssign",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_rejectOrder_TranslationId",
                table: "rejectOrder",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_GuestId",
                table: "tickets",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_DocumentRequestTypeId",
                table: "Translation",
                column: "DocumentRequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_GuestId",
                table: "Translation",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_RequestDeliveryAddresssId",
                table: "Translation",
                column: "RequestDeliveryAddresssId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_TranslationPriceId",
                table: "Translation",
                column: "TranslationPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_translationPrice_DocTypeId",
                table: "translationPrice",
                column: "DocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_translOfficeDetails_TranslOfficeId",
                table: "translOfficeDetails",
                column: "TranslOfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acceptedOrders");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bankDetails");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "feedback");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "orderAssign");

            migrationBuilder.DropTable(
                name: "rejectOrder");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "translOfficeDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "translationPrice");

            migrationBuilder.DropTable(
                name: "DocumentsType");
        }
    }
}
