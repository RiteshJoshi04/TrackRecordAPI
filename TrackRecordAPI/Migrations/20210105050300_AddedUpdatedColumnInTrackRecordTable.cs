using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class AddedUpdatedColumnInTrackRecordTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UpdatedColumn",
                table: "tblTrackRecord",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedColumn",
                table: "tblTrackRecord");

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 4, 54, 15, 427, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 4, 54, 15, 427, DateTimeKind.Utc).AddTicks(3582));
        }
    }
}
