using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    province_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.province_id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    location_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location_province_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.location_id);
                    table.ForeignKey(
                        name: "FK_Locations_Provinces_location_province_id",
                        column: x => x.location_province_id,
                        principalTable: "Provinces",
                        principalColumn: "province_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    user_password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    user_age = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    user_sex = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
                    user_location_id = table.Column<int>(type: "int", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_users_Locations_user_location_id",
                        column: x => x.user_location_id,
                        principalTable: "Locations",
                        principalColumn: "location_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_location_province_id",
                table: "Locations",
                column: "location_province_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_user_location_id",
                table: "users",
                column: "user_location_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
