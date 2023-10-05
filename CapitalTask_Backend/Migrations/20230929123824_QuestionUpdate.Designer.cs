﻿// <auto-generated />
using System;
using CaptialTask_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapitalTask_Backend.Migrations
{
    [DbContext(typeof(TaskBackendContext))]
    [Migration("20230929123824_QuestionUpdate")]
    partial class QuestionUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapitalTask_Backend.Entities.Education", b =>
                {
                    b.Property<int>("EducationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationOfStudy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("EducationID");

                    b.HasIndex("UserID");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.ProgramDetails", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplicationClose")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApplicationCriteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApplicationOpen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxNumberOfApplications")
                        .HasColumnType("int");

                    b.Property<string>("MinQualifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramBenefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProgramStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProgramTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummaryOfProgram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramId");

                    b.ToTable("ProgramDetails");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.QuestionAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionAttribute");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentResidence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgramDetailsProgramId")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("ProgramDetailsProgramId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.WorkExperience", b =>
                {
                    b.Property<int>("ExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ExperienceID");

                    b.HasIndex("UserID");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.WorkFlow", b =>
                {
                    b.Property<int>("WorkflowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeadlineForVideo")
                        .HasColumnType("datetime2");

                    b.Property<string>("InterviewQuestions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramID")
                        .HasColumnType("int");

                    b.Property<string>("StageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VideoInterview")
                        .HasColumnType("bit");

                    b.HasKey("WorkflowID");

                    b.HasIndex("ProgramID");

                    b.ToTable("WorkFlows");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.Education", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.Question", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.User", "User")
                        .WithMany("Questions")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.QuestionAttribute", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.Question", null)
                        .WithMany("Attributes")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.User", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.ProgramDetails", "ProgramDetails")
                        .WithMany("ApplicationForms")
                        .HasForeignKey("ProgramDetailsProgramId");

                    b.Navigation("ProgramDetails");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.WorkExperience", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.WorkFlow", b =>
                {
                    b.HasOne("CapitalTask_Backend.Entities.ProgramDetails", "Program")
                        .WithMany("Workflows")
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.ProgramDetails", b =>
                {
                    b.Navigation("ApplicationForms");

                    b.Navigation("Workflows");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.Question", b =>
                {
                    b.Navigation("Attributes");
                });

            modelBuilder.Entity("CapitalTask_Backend.Entities.User", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
