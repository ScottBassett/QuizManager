using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizManager.DataAccess.Migrations
{
    public partial class PutCorrectAnswerOntoAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswerId",
                table: "Questions");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Answers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswerId",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
