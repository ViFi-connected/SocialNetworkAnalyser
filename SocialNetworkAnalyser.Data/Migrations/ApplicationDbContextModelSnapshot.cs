﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialNetworkAnalyser.Data;

#nullable disable

namespace SocialNetworkAnalyser.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocialNetworkAnalyser.Data.Dataset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AvgFriendshipPerUserCount")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Datasets");
                });

            modelBuilder.Entity("SocialNetworkAnalyser.Data.Friendship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DatasetId")
                        .HasColumnType("int");

                    b.Property<long>("User1Id")
                        .HasColumnType("bigint");

                    b.Property<long>("User2Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DatasetId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("SocialNetworkAnalyser.Data.Friendship", b =>
                {
                    b.HasOne("SocialNetworkAnalyser.Data.Dataset", "Dataset")
                        .WithMany("Friendships")
                        .HasForeignKey("DatasetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dataset");
                });

            modelBuilder.Entity("SocialNetworkAnalyser.Data.Dataset", b =>
                {
                    b.Navigation("Friendships");
                });
#pragma warning restore 612, 618
        }
    }
}
