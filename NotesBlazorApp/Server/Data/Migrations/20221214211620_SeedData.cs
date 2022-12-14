using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesBlazorApp.Server.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e6ffc017-69c2-4f55-9552-9563a2cde1da", 0, "2b539445-1d12-4d62-8f73-c63feaea15e7", "user1234@mail.ru", true, true, null, "USER1234@MAIL.RU", "USER1234@MAIL.RU", "AQAAAAEAACcQAAAAEJq5wyP9ng11WdDPgSl3qdH+5qLvQi88nuYM/hS0b7+HoHky+POzcZnFLK+TAYK42Q==", null, false, "73NY4ALQX5ZVOAEBOYANZNXERLYLLSJD", false, "user1234@mail.ru" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "ChangedDate", "ColorCardId", "CreatedDate", "Details", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7055), 2, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7068), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lectus vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Faucibus scelerisque eleifend donec pretium. Turpis egestas maecenas pharetra convallis posuere morbi leo. ", "Note #1", "e6ffc017-69c2-4f55-9552-9563a2cde1da" },
                    { 2, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7071), 1, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7072), "Nunc mi ipsum faucibus vitae aliquet nec ullamcorper sit amet. Est ante in nibh mauris cursus mattis molestie a iaculis. Netus et malesuada fames ac turpis egestas maecenas pharetra. \r\n\r\nUt venenatis tellus in metus vulputate eu scelerisque felis. Purus ut faucibus pulvinar elementum integer enim neque volutpat. Rutrum tellus pellentesque eu tincidunt tortor aliquam.", "Note #2", "e6ffc017-69c2-4f55-9552-9563a2cde1da" },
                    { 3, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7074), 4, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7075), "Rutrum tellus pellentesque eu tincidunt tortor aliquam.", "Note #3", "e6ffc017-69c2-4f55-9552-9563a2cde1da" },
                    { 4, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7076), 5, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7077), "Donec ultrices tincidunt arcu non sodales neque sodales. Ultrices eros in cursus turpis massa. Nulla facilisi nullam vehicula ipsum. \r\n\r\nVitae semper quis lectus nulla at volutpat diam ut venenatis. Tellus in metus vulputate eu scelerisque felis imperdiet proin fermentum. Ullamcorper sit amet risus nullam eget felis. \r\n\r\nProin libero nunc consequat interdum varius sit amet. Sed arcu non odio euismod lacinia at quis. Faucibus a pellentesque sit amet. Urna neque viverra justo nec ultrices dui sapien eget mi. ", "Note #4", "e6ffc017-69c2-4f55-9552-9563a2cde1da" },
                    { 5, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7079), 3, new DateTime(2022, 12, 15, 0, 16, 20, 542, DateTimeKind.Local).AddTicks(7080), "Aut iste quod sed repellendus dolor eos quaerat dolores At voluptas voluptatem ea iste cupiditate. Non ipsam dignissimos et eius quia et eligendi quis.", "Note #5", "e6ffc017-69c2-4f55-9552-9563a2cde1da" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6ffc017-69c2-4f55-9552-9563a2cde1da");
        }
    }
}
