using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Migrations
{
    /// <inheritdoc />
    public partial class Update_Tables_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Provinces_location_province_id",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_users_Locations_user_location_id",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "provinces");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "locations");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_location_province_id",
                table: "locations",
                newName: "IX_locations_location_province_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provinces",
                table: "provinces",
                column: "province_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_locations",
                table: "locations",
                column: "location_id");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_provinces_location_province_id",
                table: "locations",
                column: "location_province_id",
                principalTable: "provinces",
                principalColumn: "province_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_locations_user_location_id",
                table: "users",
                column: "user_location_id",
                principalTable: "locations",
                principalColumn: "location_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_provinces_location_province_id",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_users_locations_user_location_id",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provinces",
                table: "provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_locations",
                table: "locations");

            migrationBuilder.RenameTable(
                name: "provinces",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "locations",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_locations_location_province_id",
                table: "Locations",
                newName: "IX_Locations_location_province_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "province_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "location_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Provinces_location_province_id",
                table: "Locations",
                column: "location_province_id",
                principalTable: "Provinces",
                principalColumn: "province_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_Locations_user_location_id",
                table: "users",
                column: "user_location_id",
                principalTable: "Locations",
                principalColumn: "location_id");
        }
    }
}
