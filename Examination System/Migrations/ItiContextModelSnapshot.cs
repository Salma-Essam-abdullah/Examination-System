﻿// <auto-generated />
using System;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examination_System.Migrations
{
    [DbContext(typeof(ItiContext))]
    partial class ItiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BranchDepartment", b =>
                {
                    b.Property<int>("BranchesBranchId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentListDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("BranchesBranchId", "DepartmentListDepartmentId");

                    b.HasIndex("DepartmentListDepartmentId");

                    b.ToTable("BranchDepartment");
                });

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.Property<int>("DepartmentsDepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("coursesCourseId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDepartmentId", "coursesCourseId");

                    b.HasIndex("coursesCourseId");

                    b.ToTable("CourseDepartment");
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorsInstructorId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "InstructorsInstructorId");

                    b.HasIndex("InstructorsInstructorId");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "StudentsStudentId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("DepartmentInstructor", b =>
                {
                    b.Property<int>("DepartmentsDepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("instructorsInstructorId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDepartmentId", "instructorsInstructorId");

                    b.HasIndex("instructorsInstructorId");

                    b.ToTable("DepartmentInstructor");
                });

            modelBuilder.Entity("Examination_System.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Examination_System.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<int>("BranchManagerId")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.HasIndex("BranchManagerId")
                        .IsUnique();

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Examination_System.Models.Choice", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChoiceId"));

                    b.Property<string>("ChoiceBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAnswer")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("ChoiceId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("Examination_System.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExamEndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExamStartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NumberOfMcqQuestions")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfTrueAndFalseQuestions")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Examination_System.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("ManagerId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Examination_System.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentGrade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Examination_System.Models.ExamQuestions", b =>
                {
                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamAnswers")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCorrect")
                        .HasColumnType("bit");

                    b.HasKey("ExamId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("Examination_System.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InstructorId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Examination_System.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionMark")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("QuestionId");

                    b.HasIndex("CourseId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Examination_System.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Examination_System.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("branchId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("branchId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Examination_System.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TopicId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.HasIndex("CourseId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Examination_System.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("BranchDepartment", b =>
                {
                    b.HasOne("Examination_System.Models.Branch", null)
                        .WithMany()
                        .HasForeignKey("BranchesBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentListDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.HasOne("Examination_System.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("coursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.HasOne("Examination_System.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("InstructorsInstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("Examination_System.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartmentInstructor", b =>
                {
                    b.HasOne("Examination_System.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("instructorsInstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examination_System.Models.Admin", b =>
                {
                    b.HasOne("Examination_System.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("Examination_System.Models.Admin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Examination_System.Models.Branch", b =>
                {
                    b.HasOne("Examination_System.Models.Instructor", "branchmanger")
                        .WithOne("branch")
                        .HasForeignKey("Examination_System.Models.Branch", "BranchManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("branchmanger");
                });

            modelBuilder.Entity("Examination_System.Models.Choice", b =>
                {
                    b.HasOne("Examination_System.Models.Question", "Question")
                        .WithMany("ChoicesList")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Examination_System.Models.Department", b =>
                {
                    b.HasOne("Examination_System.Models.Instructor", "Manager")
                        .WithOne("Department")
                        .HasForeignKey("Examination_System.Models.Department", "ManagerId")
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Examination_System.Models.Exam", b =>
                {
                    b.HasOne("Examination_System.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Examination_System.Models.ExamQuestions", b =>
                {
                    b.HasOne("Examination_System.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Examination_System.Models.Instructor", b =>
                {
                    b.HasOne("Examination_System.Models.User", "User")
                        .WithOne("Instructor")
                        .HasForeignKey("Examination_System.Models.Instructor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Examination_System.Models.Question", b =>
                {
                    b.HasOne("Examination_System.Models.Course", "Course")
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Examination_System.Models.Student", b =>
                {
                    b.HasOne("Examination_System.Models.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("Examination_System.Models.Student", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Branch", "Branch")
                        .WithMany("StudentList")
                        .HasForeignKey("branchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Examination_System.Models.Topic", b =>
                {
                    b.HasOne("Examination_System.Models.Course", null)
                        .WithMany("Topics")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Examination_System.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examination_System.Models.Branch", b =>
                {
                    b.Navigation("StudentList");
                });

            modelBuilder.Entity("Examination_System.Models.Course", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Questions");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("Examination_System.Models.Department", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("Examination_System.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("Examination_System.Models.Instructor", b =>
                {
                    b.Navigation("Department")
                        .IsRequired();

                    b.Navigation("branch")
                        .IsRequired();
                });

            modelBuilder.Entity("Examination_System.Models.Question", b =>
                {
                    b.Navigation("ChoicesList");

                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("Examination_System.Models.Student", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Examination_System.Models.User", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Instructor");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
