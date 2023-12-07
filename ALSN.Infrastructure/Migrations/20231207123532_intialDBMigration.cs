using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALSN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intialDBMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
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
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizationLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "serviceCategories",
                columns: table => new
                {
                    serviceCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceFee = table.Column<double>(type: "float", nullable: false),
                    RequiredTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceCategories", x => x.serviceCatId);
                });

            migrationBuilder.CreateTable(
                name: "translationPrices",
                columns: table => new
                {
                    TranslationPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sourceLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    targetLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    documentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_translationPrices", x => x.TranslationPriceId);
                });

            migrationBuilder.CreateTable(
                name: "translOffices",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizationLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalNoOfTranslators = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_translOffices", x => x.OfficeId);
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
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_tickets_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolesRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentsTypes",
                columns: table => new
                {
                    DocTypeId = table.Column<int>(type: "int", nullable: false),
                    documentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isFixedPrice = table.Column<bool>(type: "bit", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentsTypes", x => x.DocTypeId);
                    table.ForeignKey(
                        name: "FK_DocumentsTypes_translationPrices_DocTypeId",
                        column: x => x.DocTypeId,
                        principalTable: "translationPrices",
                        principalColumn: "TranslationPriceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translators",
                columns: table => new
                {
                    TranslatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalizationLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransOfficeId = table.Column<int>(type: "int", nullable: false),
                    TranslOfficeOfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translators", x => x.TranslatorId);
                    table.ForeignKey(
                        name: "FK_Translators_translOffices_TranslOfficeOfficeId",
                        column: x => x.TranslOfficeOfficeId,
                        principalTable: "translOffices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "translOfficeDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commissionPercentage = table.Column<int>(type: "int", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransOfficeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transOfficesOfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_translOfficeDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_translOfficeDetails_translOffices_transOfficesOfficeId",
                        column: x => x.transOfficesOfficeId,
                        principalTable: "translOffices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
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
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                    table.ForeignKey(
                        name: "FK_Coupons_Users_usersUserId",
                        column: x => x.usersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    TranslationRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentRequestTypeDocTypeId = table.Column<int>(type: "int", nullable: false),
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
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    TranslationPriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.TranslationRequestId);
                    table.ForeignKey(
                        name: "FK_Translations_Addresses_RequestDeliveryAddresssId",
                        column: x => x.RequestDeliveryAddresssId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translations_DocumentsTypes_DocumentRequestTypeDocTypeId",
                        column: x => x.DocumentRequestTypeDocTypeId,
                        principalTable: "DocumentsTypes",
                        principalColumn: "DocTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translations_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translations_translationPrices_TranslationPriceId",
                        column: x => x.TranslationPriceId,
                        principalTable: "translationPrices",
                        principalColumn: "TranslationPriceId",
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
                    TranslatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslatorId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankDetails", x => x.bankDetailId);
                    table.ForeignKey(
                        name: "FK_bankDetails_Translators_TranslatorId1",
                        column: x => x.TranslatorId1,
                        principalTable: "Translators",
                        principalColumn: "TranslatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_languages_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "TranslatorId");
                });

            migrationBuilder.CreateTable(
                name: "acceptedOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslationId = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acceptedOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_acceptedOrders_Translations_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translations",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_acceptedOrders_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "TranslatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    translationId = table.Column<int>(type: "int", nullable: false),
                    TranslatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_feedbacks_Translations_translationId",
                        column: x => x.translationId,
                        principalTable: "Translations",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_feedbacks_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "TranslatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderAssigns",
                columns: table => new
                {
                    assignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslatorId = table.Column<int>(type: "int", nullable: false),
                    TranslationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderAssigns", x => x.assignId);
                    table.ForeignKey(
                        name: "FK_orderAssigns_Translations_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translations",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderAssigns_Translators_TranslatorId",
                        column: x => x.TranslatorId,
                        principalTable: "Translators",
                        principalColumn: "TranslatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rejectOrders",
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
                    table.PrimaryKey("PK_rejectOrders", x => x.RejectionId);
                    table.ForeignKey(
                        name: "FK_rejectOrders_Translations_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translations",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_acceptedOrders_TranslationId",
                table: "acceptedOrders",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_acceptedOrders_TranslatorId",
                table: "acceptedOrders",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_bankDetails_TranslatorId1",
                table: "bankDetails",
                column: "TranslatorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_usersUserId",
                table: "Coupons",
                column: "usersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_translationId",
                table: "feedbacks",
                column: "translationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_TranslatorId",
                table: "feedbacks",
                column: "TranslatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_languages_TranslatorId",
                table: "languages",
                column: "TranslatorId");

            migrationBuilder.CreateIndex(
                name: "IX_orderAssigns_TranslationId",
                table: "orderAssigns",
                column: "TranslationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_orderAssigns_TranslatorId",
                table: "orderAssigns",
                column: "TranslatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_rejectOrders_TranslationId",
                table: "rejectOrders",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_GuestId",
                table: "tickets",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_DocumentRequestTypeDocTypeId",
                table: "Translations",
                column: "DocumentRequestTypeDocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_GuestId",
                table: "Translations",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_RequestDeliveryAddresssId",
                table: "Translations",
                column: "RequestDeliveryAddresssId");

            migrationBuilder.CreateIndex(
                name: "IX_Translations_TranslationPriceId",
                table: "Translations",
                column: "TranslationPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Translators_TranslOfficeOfficeId",
                table: "Translators",
                column: "TranslOfficeOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_translOfficeDetails_transOfficesOfficeId",
                table: "translOfficeDetails",
                column: "transOfficesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolesRoleId",
                table: "Users",
                column: "RolesRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acceptedOrders");

            migrationBuilder.DropTable(
                name: "bankDetails");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "orderAssigns");

            migrationBuilder.DropTable(
                name: "rejectOrders");

            migrationBuilder.DropTable(
                name: "serviceCategories");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "translOfficeDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Translators");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "translOffices");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "DocumentsTypes");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "translationPrices");
        }
    }
}
