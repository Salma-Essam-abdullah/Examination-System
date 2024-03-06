﻿// <auto-generated />
using System;
using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examination_System.Migrations
{
    [DbContext(typeof(ItiContext))]
    [Migration("20240306191717_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Examination_System.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("BranchManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

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

                    b.Property<int?>("ExamQuestionsExamId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamQuestionsQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentGrade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.HasIndex("ExamQuestionsExamId", "ExamQuestionsQuestionId");

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

                    b.Property<string>("InstructorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorId");

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

                    b.Property<int?>("ExamQuestionsExamId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamQuestionsQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("ModelAnswerId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionMark")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ModelAnswerId")
                        .IsUnique();

                    b.HasIndex("ExamQuestionsExamId", "ExamQuestionsQuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Examination_System.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmentId");

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

            modelBuilder.Entity("Examination_System.Models.Choice", b =>
                {
                    b.HasOne("Examination_System.Models.Question", null)
                        .WithMany("ChoicesList")
                        .HasForeignKey("QuestionId")
                        .IsRequired();
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

                    b.HasOne("Examination_System.Models.ExamQuestions", null)
                        .WithMany("Exams")
                        .HasForeignKey("ExamQuestionsExamId", "ExamQuestionsQuestionId");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Examination_System.Models.ExamQuestions", b =>
                {
                    b.HasOne("Examination_System.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamId")
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Question", "Question")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("QuestionId")
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Examination_System.Models.Question", b =>
                {
                    b.HasOne("Examination_System.Models.Course", "Course")
                        .WithMany("Questions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examination_System.Models.Choice", "ModelAnswer")
                        .WithOne("Question")
                        .HasForeignKey("Examination_System.Models.Question", "ModelAnswerId")
                        .IsRequired();

                    b.HasOne("Examination_System.Models.ExamQuestions", null)
                        .WithMany("Questions")
                        .HasForeignKey("ExamQuestionsExamId", "ExamQuestionsQuestionId");

                    b.Navigation("Course");

                    b.Navigation("ModelAnswer");
                });

            modelBuilder.Entity("Examination_System.Models.Student", b =>
                {
                    b.HasOne("Examination_System.Models.Department", "Department")
                        .WithMany("students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Examination_System.Models.Topic", b =>
                {
                    b.HasOne("Examination_System.Models.Course", null)
                        .WithMany("Topics")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examination_System.Models.Choice", b =>
                {
                    b.Navigation("Question")
                        .IsRequired();
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

            modelBuilder.Entity("Examination_System.Models.ExamQuestions", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Examination_System.Models.Instructor", b =>
                {
                    b.Navigation("Department")
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
#pragma warning restore 612, 618
        }
    }
}
