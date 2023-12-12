using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ALSN.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddChatsPaymentSErviceCategoryPaymentDetail_tbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fe6fa9e-152d-49d4-8ba6-ceb6875294f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509b7411-1122-49be-a5d6-e616adaf79cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac1c3372-432d-41b8-b86a-87feb2cf846a");

            migrationBuilder.CreateTable(
                name: "chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TranslationId = table.Column<int>(type: "int", nullable: false),
                    GuestID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TranslatorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chats_AspNetUsers_GuestID",
                        column: x => x.GuestID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_chats_AspNetUsers_TranslatorID",
                        column: x => x.TranslatorID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_chats_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serviceCategory",
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
                    table.PrimaryKey("PK_serviceCategory", x => x.serviceCatId);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TranslationOfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    translationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_AspNetUsers_GuestId",
                        column: x => x.GuestId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_AspNetUsers_TranslationOfficeId",
                        column: x => x.TranslationOfficeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_Translation_translationId",
                        column: x => x.translationId,
                        principalTable: "Translation",
                        principalColumn: "TranslationRequestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_serviceCategory_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "serviceCategory",
                        principalColumn: "serviceCatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "paymentDetails",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    Debit = table.Column<int>(type: "int", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetails", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_paymentDetails_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e580075e-6b2c-439a-b164-e001877962d6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49e6245a-4d44-4610-9a40-3ba440abe190", "2d838714-bfb9-45f2-a935-e73790f1aec9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TransOfficeId", "TwoFactorEnabled", "UserName", "fullAddress" },
                values: new object[] { "9fbb9a41-e39c-45f8-a06c-00fd5fca150c", 0, "9565e631-1ca6-42b4-a6b1-696a7bd89a9c", "03149276066", "Translators", "sample.translator@example.com", false, "Sample Translator", "English", false, null, null, null, "hashed_password_here", null, false, "c0145a1b-3e65-41e4-9a29-f9dbda0978f1", "e580075e-6b2c-439a-b164-e001877962d6", false, null, "Xyz Address" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c4b55440-4620-4ed5-8ba9-308d5ba7991e", 0, "a2880a88-b50e-4cf8-8c0f-33dbf15572f8", "03149276066", "Guest", "sample.guest@example.com", false, "Sample Guest", "English", false, null, null, null, "hashed_password_here", null, false, "8d99ea47-9d70-44b1-ba1f-1a5ddeb2d35b", false, null },
                    { "cc21288e-b706-4de1-aa8b-e99d2368ffd1", 0, "6c9a6dbe-adf3-4a4d-83ca-f06fe1937f97", "03149276066", "ApplicationUser", "sample.applicationuser@example.com", false, "Abdullah Khan", "English", false, null, null, null, "hashed_password_here", null, false, "2d915ae3-deeb-4a9b-8cd3-c08b9793a4c3", false, "sample.applicationuser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_chats_GuestID",
                table: "chats",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_chats_TranslationId",
                table: "chats",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_chats_TranslatorID",
                table: "chats",
                column: "TranslatorID");

            migrationBuilder.CreateIndex(
                name: "IX_paymentDetails_PaymentId",
                table: "paymentDetails",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_GuestId",
                table: "payments",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_ServiceTypeId",
                table: "payments",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_translationId",
                table: "payments",
                column: "translationId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_TranslationOfficeId",
                table: "payments",
                column: "TranslationOfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chats");

            migrationBuilder.DropTable(
                name: "paymentDetails");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "serviceCategory");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fbb9a41-e39c-45f8-a06c-00fd5fca150c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4b55440-4620-4ed5-8ba9-308d5ba7991e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc21288e-b706-4de1-aa8b-e99d2368ffd1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e580075e-6b2c-439a-b164-e001877962d6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad4d7305-6efc-434b-b5e6-207342e0ff29", "ec9bbbfe-94da-4848-a0ab-a9ac05b3c4ed" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TransOfficeId", "TwoFactorEnabled", "UserName", "fullAddress" },
                values: new object[] { "0fe6fa9e-152d-49d4-8ba6-ceb6875294f3", 0, "eca1d256-b474-4a5a-9a67-1e428889dff3", "03149276066", "Translators", "sample.translator@example.com", false, "Sample Translator", "English", false, null, null, null, "hashed_password_here", null, false, "4b62674c-bf52-4c15-b07f-4e6e1cbf17b7", "e580075e-6b2c-439a-b164-e001877962d6", false, null, "Xyz Address" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactNo", "Discriminator", "Email", "EmailConfirmed", "FullName", "LocalizationLanguage", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "509b7411-1122-49be-a5d6-e616adaf79cd", 0, "da4d791f-59fd-48f0-92e0-b049a2c4b45a", "03149276066", "ApplicationUser", "sample.applicationuser@example.com", false, "Abdullah Khan", "English", false, null, null, null, "hashed_password_here", null, false, "97837b56-c737-49fc-9537-8da50cf7444c", false, "sample.applicationuser" },
                    { "ac1c3372-432d-41b8-b86a-87feb2cf846a", 0, "5dc4315c-17d2-4ff1-be8b-16fa9d76090e", "03149276066", "Guest", "sample.guest@example.com", false, "Sample Guest", "English", false, null, null, null, "hashed_password_here", null, false, "fe7e087a-9738-4d1e-9639-3289b6815465", false, null }
                });
        }
    }
}
