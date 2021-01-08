using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class ChangedTrackRecordColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OldValue",
                table: "tblTrackRecord",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 59, 49, 847, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 59, 49, 847, DateTimeKind.Utc).AddTicks(8471));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldValue",
                table: "tblTrackRecord");

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 45, 47, 700, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 5, 45, 47, 700, DateTimeKind.Utc).AddTicks(8123));
        }
    }
}
