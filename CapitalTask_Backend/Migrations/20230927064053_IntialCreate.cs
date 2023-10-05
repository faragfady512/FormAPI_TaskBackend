using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapitalTask_Backend.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramDetails",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryOfProgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeySkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramBenefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationCriteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinQualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxNumberOfApplications = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDetails", x => x.ProgramId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramDetailsProgramId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_ProgramDetails_ProgramDetailsProgramId",
                        column: x => x.ProgramDetailsProgramId,
                        principalTable: "ProgramDetails",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlows",
                columns: table => new
                {
                    WorkflowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramID = table.Column<int>(type: "int", nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoInterview = table.Column<bool>(type: "bit", nullable: false),
                    InterviewQuestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeadlineForVideo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlows", x => x.WorkflowID);
                    table.ForeignKey(
                        name: "FK_WorkFlows_ProgramDetails_ProgramID",
                        column: x => x.ProgramID,
                        principalTable: "ProgramDetails",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationOfStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EducationID);
                    table.ForeignKey(
                        name: "FK_Education_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    QuestionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Choices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxChoicesAllowed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Question_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.ExperienceID);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_UserID",
                table: "Education",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UserID",
                table: "Question",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProgramDetailsProgramId",
                table: "User",
                column: "ProgramDetailsProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_UserID",
                table: "WorkExperiences",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlows_ProgramID",
                table: "WorkFlows",
                column: "ProgramID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "WorkFlows");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProgramDetails");
        }
    }
}
