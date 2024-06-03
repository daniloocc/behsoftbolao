﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using behsoftbolao.api.Data;

#nullable disable

namespace behsoftbolao.api.Migrations
{
    [DbContext(typeof(BolaoDbContext))]
    [Migration("20240603170520_add_indexes")]
    partial class add_indexes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Bolao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CampeonatoAnualId")
                        .HasColumnType("uuid");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DonoId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Updated")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoAnualId");

                    b.HasIndex("Codigo")
                        .IsUnique()
                        .HasDatabaseName("UX_codigo_bolao");

                    b.HasIndex("DonoId");

                    b.ToTable("Boloes");
                });

            modelBuilder.Entity("Core.Models.CampeonatoAnual", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<Guid>("CampeonatoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DataEncerramento")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoId", "Ano")
                        .IsUnique();

                    b.ToTable("CampeonatoAnual");
                });

            modelBuilder.Entity("Core.Models.Jogo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CampeonatoAnualId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("PlacarTimeDois")
                        .HasColumnType("integer");

                    b.Property<int?>("PlacarTimeUm")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TimeDoisId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TimeUmId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoAnualId");

                    b.HasIndex("TimeDoisId");

                    b.HasIndex("TimeUmId");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("Core.Models.Palpite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("JogoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ParticipanteID")
                        .HasColumnType("uuid");

                    b.Property<int?>("PontosTimeDois")
                        .HasColumnType("integer");

                    b.Property<int?>("PontosTimeUm")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("JogoId");

                    b.HasIndex("ParticipanteID", "JogoId")
                        .IsUnique();

                    b.ToTable("Palpites");
                });

            modelBuilder.Entity("Core.Models.Participante", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BolaoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Pontuacao")
                        .HasColumnType("integer");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BolaoId");

                    b.HasIndex("UsuarioId", "BolaoId")
                        .IsUnique();

                    b.ToTable("Participante");
                });

            modelBuilder.Entity("Database.Models.Campeonato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("Id");

                    b.ToTable("Campeonato");
                });

            modelBuilder.Entity("Database.Models.Time", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IconeBandeira")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("Database.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Core.Models.Bolao", b =>
                {
                    b.HasOne("Core.Models.CampeonatoAnual", "CampeonatoAnual")
                        .WithMany("Boloes")
                        .HasForeignKey("CampeonatoAnualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Usuario", "Dono")
                        .WithMany("Dono")
                        .HasForeignKey("DonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CampeonatoAnual");

                    b.Navigation("Dono");
                });

            modelBuilder.Entity("Core.Models.CampeonatoAnual", b =>
                {
                    b.HasOne("Database.Models.Campeonato", "Campeonato")
                        .WithMany("CampeonatosAnuais")
                        .HasForeignKey("CampeonatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campeonato");
                });

            modelBuilder.Entity("Core.Models.Jogo", b =>
                {
                    b.HasOne("Core.Models.CampeonatoAnual", "CampeonatoAnual")
                        .WithMany("Jogos")
                        .HasForeignKey("CampeonatoAnualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Time", "TimeDois")
                        .WithMany("TimesDois")
                        .HasForeignKey("TimeDoisId");

                    b.HasOne("Database.Models.Time", "TimeUm")
                        .WithMany("TimesUm")
                        .HasForeignKey("TimeUmId");

                    b.Navigation("CampeonatoAnual");

                    b.Navigation("TimeDois");

                    b.Navigation("TimeUm");
                });

            modelBuilder.Entity("Core.Models.Palpite", b =>
                {
                    b.HasOne("Core.Models.Jogo", "Jogo")
                        .WithMany("Plapites")
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Participante", "Participante")
                        .WithMany("Palpites")
                        .HasForeignKey("ParticipanteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Participante");
                });

            modelBuilder.Entity("Core.Models.Participante", b =>
                {
                    b.HasOne("Core.Models.Bolao", "Bolao")
                        .WithMany("Participantes")
                        .HasForeignKey("BolaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Usuario", "Usuario")
                        .WithMany("Participante")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Core.Models.Bolao", b =>
                {
                    b.Navigation("Participantes");
                });

            modelBuilder.Entity("Core.Models.CampeonatoAnual", b =>
                {
                    b.Navigation("Boloes");

                    b.Navigation("Jogos");
                });

            modelBuilder.Entity("Core.Models.Jogo", b =>
                {
                    b.Navigation("Plapites");
                });

            modelBuilder.Entity("Core.Models.Participante", b =>
                {
                    b.Navigation("Palpites");
                });

            modelBuilder.Entity("Database.Models.Campeonato", b =>
                {
                    b.Navigation("CampeonatosAnuais");
                });

            modelBuilder.Entity("Database.Models.Time", b =>
                {
                    b.Navigation("TimesDois");

                    b.Navigation("TimesUm");
                });

            modelBuilder.Entity("Database.Models.Usuario", b =>
                {
                    b.Navigation("Dono");

                    b.Navigation("Participante");
                });
#pragma warning restore 612, 618
        }
    }
}
