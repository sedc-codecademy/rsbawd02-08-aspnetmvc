using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEf.Migrations
{
    public partial class _003_Added_reference_date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "IsActiveCourse", "Name", "NumberOfClasses" },
                values: new object[,]
                {
                    { 1, false, "C# basic", 40 },
                    { 2, false, "C# Advanced", 60 },
                    { 3, false, "Database development and design", 28 },
                    { 4, false, "ASP.NET Mvc", 40 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActiveCourseId", "DateOfBirth", "FirstName", "LastName", "ParentName" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1997, 9, 6, 21, 6, 24, 405, DateTimeKind.Local).AddTicks(11), "Bob", "Bobski", "David" },
                    { 2, 4, new DateTime(1987, 9, 6, 21, 6, 24, 405, DateTimeKind.Local).AddTicks(89), "Jill", "Jilski", "Milena" },
                    { 3, 4, new DateTime(1979, 9, 6, 21, 6, 24, 405, DateTimeKind.Local).AddTicks(92), "John", "Doe", "Jovan" },
                    { 4, 4, new DateTime(2007, 9, 6, 21, 6, 24, 405, DateTimeKind.Local).AddTicks(95), "Jane", "Doe", "Ana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
