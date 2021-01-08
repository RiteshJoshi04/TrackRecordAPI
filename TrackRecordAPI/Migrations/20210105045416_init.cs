using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackRecordAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblStudent",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    StudentAge = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudent", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "tblTrackRecord",
                columns: table => new
                {
                    TID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTrackRecord", x => x.TID);
                });

            migrationBuilder.InsertData(
                table: "tblStudent",
                columns: new[] { "StudentId", "DOB", "FirstName", "LastName", "StudentAge" },
                values: new object[] { 1, new DateTime(2021, 1, 5, 4, 54, 15, 427, DateTimeKind.Utc).AddTicks(2446), "Ritesh", "Joshi", 22 });

            migrationBuilder.InsertData(
                table: "tblStudent",
                columns: new[] { "StudentId", "DOB", "FirstName", "LastName", "StudentAge" },
                values: new object[] { 2, new DateTime(2021, 1, 5, 4, 54, 15, 427, DateTimeKind.Utc).AddTicks(3582), "Amit", "Joshi", 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblStudent");

            migrationBuilder.DropTable(
                name: "tblTrackRecord");
        }
    }
}
