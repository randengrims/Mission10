using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullStackFun.Migrations
{
    /// <inheritdoc />
    public partial class bowlersv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Bowlers");

            migrationBuilder.RenameColumn(
                name: "BowlerId",
                table: "Bowlers",
                newName: "BowlerID");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Bowlers",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "Bowlers",
                newName: "BowlerState");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Bowlers",
                newName: "BowlerFirstName");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Bowlers",
                newName: "BowlerZip");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Bowlers",
                newName: "BowlerCity");

            migrationBuilder.RenameColumn(
                name: "BowlerName",
                table: "Bowlers",
                newName: "BowlerAddress");

            migrationBuilder.AddColumn<int>(
                name: "BowlerPhoneNumber",
                table: "Bowlers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bowlers_TeamID",
                table: "Bowlers",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bowlers_Teams_TeamID",
                table: "Bowlers",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bowlers_Teams_TeamID",
                table: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Bowlers_TeamID",
                table: "Bowlers");

            migrationBuilder.DropColumn(
                name: "BowlerPhoneNumber",
                table: "Bowlers");

            migrationBuilder.RenameColumn(
                name: "BowlerID",
                table: "Bowlers",
                newName: "BowlerId");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Bowlers",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "BowlerZip",
                table: "Bowlers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "BowlerState",
                table: "Bowlers",
                newName: "TeamName");

            migrationBuilder.RenameColumn(
                name: "BowlerFirstName",
                table: "Bowlers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "BowlerCity",
                table: "Bowlers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "BowlerAddress",
                table: "Bowlers",
                newName: "BowlerName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Bowlers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
