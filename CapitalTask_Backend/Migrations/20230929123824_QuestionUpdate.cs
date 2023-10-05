using Microsoft.EntityFrameworkCore.Migrations;

namespace CapitalTask_Backend.Migrations
{
    public partial class QuestionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_User_UserID",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "MaxChoicesAllowed",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "QuestionText",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "Choices",
                table: "Question",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "Question",
                newName: "Type");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Question",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Question",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "QuestionAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAttribute_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAttribute_QuestionId",
                table: "QuestionAttribute",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_User_UserID",
                table: "Question",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_User_UserID",
                table: "Question");

            migrationBuilder.DropTable(
                name: "QuestionAttribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Question",
                newName: "QuestionID");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Question",
                newName: "Choices");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionID",
                table: "Question",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaxChoicesAllowed",
                table: "Question",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuestionText",
                table: "Question",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "Question",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_User_UserID",
                table: "Question",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
