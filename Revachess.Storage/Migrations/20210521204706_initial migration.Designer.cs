﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revachess.Storage;

namespace Revachess.Storage.Migrations
{
    [DbContext(typeof(ChessContext))]
    [Migration("20210521204706_initial migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Revachess.Domain.Models.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Player1Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("Player2Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("WinnerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Player1Id");

                    b.HasIndex("Player2Id");

                    b.HasIndex("WinnerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Revachess.Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            UserName = "Fed"
                        },
                        new
                        {
                            Id = 2L,
                            UserName = "fred"
                        });
                });

            modelBuilder.Entity("Revachess.Domain.Models.Game", b =>
                {
                    b.HasOne("Revachess.Domain.Models.User", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1Id");

                    b.HasOne("Revachess.Domain.Models.User", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2Id");

                    b.HasOne("Revachess.Domain.Models.User", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");

                    b.Navigation("Player1");

                    b.Navigation("Player2");

                    b.Navigation("Winner");
                });
#pragma warning restore 612, 618
        }
    }
}
