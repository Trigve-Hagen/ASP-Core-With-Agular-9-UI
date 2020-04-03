using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationDataLibrary.Migrations
{
    public partial class ApplicationAddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "MemberType", "Password", "ResetToken", "Status", "Username" },
                values: new object[] { 1, "Trigve", "Hagen", 1, "xu2G3G679Ax7wvFWg1VE3YFlTz8lh9yoDZ+KnBz0M2U=", null, 1, "trigve1" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "MemberType", "Password", "ResetToken", "Status", "Username" },
                values: new object[] { 2, "Trigve", "Hagen", 2, "xu2G3G679Ax7wvFWg1VE3YFlTz8lh9yoDZ+KnBz0M2U=", null, 1, "trigve2" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "MemberType", "Password", "ResetToken", "Status", "Username" },
                values: new object[] { 3, "Trigve", "Hagen", 3, "xu2G3G679Ax7wvFWg1VE3YFlTz8lh9yoDZ+KnBz0M2U=", null, 1, "trigve3" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PersonId", "State", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Lodi", 1, "CA", "13066 Paddy Creek Ln", 95240 },
                    { 2, "Lodi", 2, "CA", "13066 Paddy Creek Ln", 95240 },
                    { 3, "Lodi", 3, "CA", "13066 Paddy Creek Ln", 95240 }
                });

            migrationBuilder.InsertData(
                table: "EmailAddresses",
                columns: new[] { "Id", "EmailAddress", "PersonId" },
                values: new object[,]
                {
                    { 1, "trigve.hagen@gmail.com", 1 },
                    { 2, "trigve.hagen@gmail.com", 2 },
                    { 3, "trigve.hagen@gmail.com", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmailAddresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "EmailAddresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Addresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_PersonId",
                table: "Addresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_People_PersonId",
                table: "EmailAddresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
