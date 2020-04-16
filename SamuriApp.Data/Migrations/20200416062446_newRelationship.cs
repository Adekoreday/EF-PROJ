using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuriApp.Data.Migrations
{
    public partial class newRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SamuriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horses_Samuris_SamuriId",
                        column: x => x.SamuriId,
                        principalTable: "Samuris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SamuriBattle",
                columns: table => new
                {
                    BattleId = table.Column<int>(nullable: false),
                    SamuriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuriBattle", x => new { x.SamuriId, x.BattleId });
                    table.ForeignKey(
                        name: "FK_SamuriBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuriBattle_Samuris_SamuriId",
                        column: x => x.SamuriId,
                        principalTable: "Samuris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horses_SamuriId",
                table: "Horses",
                column: "SamuriId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SamuriBattle_BattleId",
                table: "SamuriBattle",
                column: "BattleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "SamuriBattle");

            migrationBuilder.DropTable(
                name: "Battles");
        }
    }
}
