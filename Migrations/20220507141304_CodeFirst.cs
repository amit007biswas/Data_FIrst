using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_FIrst.Migrations
{
    public partial class CodeFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "custb",
                columns: table => new
                {
                    userid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    pwd = table.Column<string>(nullable: false),
                    Confirmpwd = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custb", x => x.userid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "custb");
        }
    }
}
