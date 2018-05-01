﻿// <auto-generated />
using System;
using DemoConsole.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoConsole.Migrations
{
    [DbContext(typeof(ActorDbContext))]
    [Migration("20180501162928_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoConsole.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcademyWinner");

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}
