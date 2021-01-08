using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class ChangedUpdatedTimeColumnType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "UpdatedTime",
                table: "tblTrackRecord",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "tblTrackRecord",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

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
    }
}
