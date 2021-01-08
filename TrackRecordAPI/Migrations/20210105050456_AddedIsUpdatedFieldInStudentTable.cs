using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class AddedIsUpdatedFieldInStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUpdated",
                table: "tblStudent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 4, 54, 940, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 4, 54, 940, DateTimeKind.Utc).AddTicks(2472));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUpdated",
                table: "tblStudent");

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 2, 59, 711, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 2, 59, 711, DateTimeKind.Utc).AddTicks(3631));
        }
    }
}
