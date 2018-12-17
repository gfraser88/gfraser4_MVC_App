﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gfraser4_College_Strike.Data;

namespace gfraser4_College_Strike.Data.MOMigrations
{
    [DbContext(typeof(CollegeStrikeContext))]
    partial class CollegeStrikeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("CS")
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("gfraser4_College_Strike.Models.Assignment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignmentName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentName")
                        .IsUnique();

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentID");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("Phone");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("imageContent");

                    b.Property<string>("imageFileName")
                        .HasMaxLength(100);

                    b.Property<string>("imageMimeType")
                        .HasMaxLength(256);

                    b.HasKey("ID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("eMail")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.MemberPosition", b =>
                {
                    b.Property<int>("PositionID");

                    b.Property<int>("MemberID");

                    b.HasKey("PositionID", "MemberID");

                    b.HasIndex("MemberID");

                    b.ToTable("MemberPositions");
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.Shift", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignmentID");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("MemberID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("ShiftDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("MemberID", "ShiftDate")
                        .IsUnique();

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.Member", b =>
                {
                    b.HasOne("gfraser4_College_Strike.Models.Assignment", "Assignment")
                        .WithMany("Members")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.MemberPosition", b =>
                {
                    b.HasOne("gfraser4_College_Strike.Models.Member", "Member")
                        .WithMany("MemberPositions")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("gfraser4_College_Strike.Models.Position", "Position")
                        .WithMany("MemberPositions")
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("gfraser4_College_Strike.Models.Shift", b =>
                {
                    b.HasOne("gfraser4_College_Strike.Models.Assignment", "Assignment")
                        .WithMany("Shifts")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("gfraser4_College_Strike.Models.Member", "Member")
                        .WithMany("Shifts")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}