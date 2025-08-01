﻿// <auto-generated />
using System;
using BlackBelt.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlackBelt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlackBelt.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("Dt_Matricula")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("Dt_Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faixa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Turma")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Turma");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("BlackBelt.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avaliacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Aluno")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Aluno");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("BlackBelt.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dt_Login")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Usuario");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("BlackBelt.Models.Presenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dt_Aula")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Aluno")
                        .HasColumnType("int");

                    b.Property<int>("Id_Turma")
                        .HasColumnType("int");

                    b.Property<bool>("Presente")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_Aluno");

                    b.HasIndex("Id_Turma");

                    b.ToTable("Presencas");
                });

            modelBuilder.Entity("BlackBelt.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dt_Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("Id_Instrutor")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Instrutor");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("BlackBelt.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateOnly>("Dt_Nascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BlackBelt.Models.Aluno", b =>
                {
                    b.HasOne("BlackBelt.Models.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("Id_Turma")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("BlackBelt.Models.Habilidade", b =>
                {
                    b.HasOne("BlackBelt.Models.Aluno", "Aluno")
                        .WithMany("Habilidades")
                        .HasForeignKey("Id_Aluno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("BlackBelt.Models.Login", b =>
                {
                    b.HasOne("BlackBelt.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BlackBelt.Models.Presenca", b =>
                {
                    b.HasOne("BlackBelt.Models.Aluno", "Aluno")
                        .WithMany("Presencas")
                        .HasForeignKey("Id_Aluno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlackBelt.Models.Turma", "Turma")
                        .WithMany("Presencas")
                        .HasForeignKey("Id_Turma")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("BlackBelt.Models.Turma", b =>
                {
                    b.HasOne("BlackBelt.Models.Usuario", "Instrutor")
                        .WithMany("Turmas")
                        .HasForeignKey("Id_Instrutor")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Instrutor");
                });

            modelBuilder.Entity("BlackBelt.Models.Aluno", b =>
                {
                    b.Navigation("Habilidades");

                    b.Navigation("Presencas");
                });

            modelBuilder.Entity("BlackBelt.Models.Turma", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Presencas");
                });

            modelBuilder.Entity("BlackBelt.Models.Usuario", b =>
                {
                    b.Navigation("Turmas");
                });
#pragma warning restore 612, 618
        }
    }
}
