using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplicationHTML_TO_EXCEL_EXPORT.Migrations
{
    /// <inheritdoc />
    public partial class Initialize_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "Email", "Name", "PhoneNO" },
                values: new object[,]
                {
                    { 1, "kamal@gmail.com", "kamal", "03123454546" },
                    { 2, "Nofile@gmail.com", "Nofile", "03126785643" },
                    { 3, "Ashir@gmail.com", "Ashir", "03123456785" },
                    { 4, "jawad@gmail.com", "jawad", "03123489754" },
                    { 5, "jawaid@gmail.com", "jawaid", "031575367906" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
