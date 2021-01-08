using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class ChangedUpdatedValueColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblTrackRecord",
                newName: "UpdatedValue");

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 6, 8, 34, 658, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "tblStudent",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2021, 1, 5, 6, 8, 34, 658, DateTimeKind.Utc).AddTicks(4659));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedValue",
                table: "tblTrackRecord",
                newName: "Name");

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
    }
}
