﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokemonsAPI.Data;

#nullable disable

namespace PokemonsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240510133726_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AbilityPokemonDetails", b =>
                {
                    b.Property<int>("AbilitiesId")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonsDetailsId")
                        .HasColumnType("integer");

                    b.HasKey("AbilitiesId", "PokemonsDetailsId");

                    b.HasIndex("PokemonsDetailsId");

                    b.ToTable("AbilityPokemonDetails");
                });

            modelBuilder.Entity("MovePokemonDetails", b =>
                {
                    b.Property<int>("MovesId")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonsDetailsId")
                        .HasColumnType("integer");

                    b.HasKey("MovesId", "PokemonsDetailsId");

                    b.HasIndex("PokemonsDetailsId");

                    b.ToTable("MovePokemonDetails");
                });

            modelBuilder.Entity("PokemonDetailsPokemonType", b =>
                {
                    b.Property<int>("PokemonsDetailsId")
                        .HasColumnType("integer");

                    b.Property<int>("TypesId")
                        .HasColumnType("integer");

                    b.HasKey("PokemonsDetailsId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("PokemonDetailsPokemonType");
                });

            modelBuilder.Entity("PokemonPokemonType", b =>
                {
                    b.Property<int>("PokemonsId")
                        .HasColumnType("integer");

                    b.Property<int>("TypesId")
                        .HasColumnType("integer");

                    b.HasKey("PokemonsId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("PokemonPokemonType");
                });

            modelBuilder.Entity("PokemonsAPI.Models.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("PokemonsAPI.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("PokemonsAPI.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PokemonId")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId")
                        .IsUnique();

                    b.ToTable("PokemonsDetails");
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Attack")
                        .HasColumnType("integer");

                    b.Property<int>("Defense")
                        .HasColumnType("integer");

                    b.Property<int>("Hp")
                        .HasColumnType("integer");

                    b.Property<int>("PokemonDetailsId")
                        .HasColumnType("integer");

                    b.Property<int>("SpecialAttack")
                        .HasColumnType("integer");

                    b.Property<int>("SpecialDefense")
                        .HasColumnType("integer");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PokemonDetailsId")
                        .IsUnique();

                    b.ToTable("PokemonsStats");
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("AbilityPokemonDetails", b =>
                {
                    b.HasOne("PokemonsAPI.Models.Ability", null)
                        .WithMany()
                        .HasForeignKey("AbilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonsAPI.Models.PokemonDetails", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovePokemonDetails", b =>
                {
                    b.HasOne("PokemonsAPI.Models.Move", null)
                        .WithMany()
                        .HasForeignKey("MovesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonsAPI.Models.PokemonDetails", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokemonDetailsPokemonType", b =>
                {
                    b.HasOne("PokemonsAPI.Models.PokemonDetails", null)
                        .WithMany()
                        .HasForeignKey("PokemonsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonsAPI.Models.PokemonType", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokemonPokemonType", b =>
                {
                    b.HasOne("PokemonsAPI.Models.Pokemon", null)
                        .WithMany()
                        .HasForeignKey("PokemonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonsAPI.Models.PokemonType", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonDetails", b =>
                {
                    b.HasOne("PokemonsAPI.Models.Pokemon", "Pokemon")
                        .WithOne("Details")
                        .HasForeignKey("PokemonsAPI.Models.PokemonDetails", "PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonStats", b =>
                {
                    b.HasOne("PokemonsAPI.Models.PokemonDetails", "Details")
                        .WithOne("Stats")
                        .HasForeignKey("PokemonsAPI.Models.PokemonStats", "PokemonDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });

            modelBuilder.Entity("PokemonsAPI.Models.Pokemon", b =>
                {
                    b.Navigation("Details")
                        .IsRequired();
                });

            modelBuilder.Entity("PokemonsAPI.Models.PokemonDetails", b =>
                {
                    b.Navigation("Stats")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
