using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class AddFullNameProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Student",
                newName: "FirstName");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Student",
                newName: "FirstMidName");
        }
    }
}
