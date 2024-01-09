using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DnDExamBL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "ArmorClass", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { 1, 15, 3, 1, "3d6", 2, 40, "Warlock" },
                    { 2, 12, 1, 2, "1d4", 0, 25, "Goblin" },
                    { 3, 18, 3, 5, "4d8", 3, 80, "Dragon" },
                    { 4, 14, -2, 2, "3d4", 1, 35, "Orc" },
                    { 5, 10, 0, 1, "1d8", 0, 15, "Skeleton" },
                    { 6, 16, 4, 2, "2d8", 3, 50, "Troll" },
                    { 7, 13, 1, 1, "3d4", -2, 30, "Wraith" },
                    { 8, 11, -1, 2, "1d10", 0, 20, "Harpy" },
                    { 9, 17, 3, 3, "4d4", 2, 60, "Beholder" },
                    { 10, 19, -2, 4, "5d6", 3, 70, "Lich" },
                    { 11, 15, 3, 1, "1d12", -1, 45, "Minotaur" },
                    { 12, 16, -1, 1, "1d10", 0, 55, "Gorgon" },
                    { 13, 18, 2, 2, "2d6", 1, 65, "Sphinx" },
                    { 14, 12, 2, 1, "1d4", 0, 25, "Banshee" },
                    { 15, 20, 3, 3, "2d6", 1, 75, "Chimera" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 15);
        }
    }
}
