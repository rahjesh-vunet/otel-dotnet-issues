﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using frm.Models;

#nullable disable

namespace frm.Migrations
{
    [DbContext(typeof(FrmContext))]
    [Migration("20231127173926_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FrmApp.Models.DTOs.RiskScoreResponseDTO", b =>
                {
                    b.Property<string>("Rrn")
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("Relational:JsonPropertyName", "rrn");

                    b.Property<string>("CustId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "custID");

                    b.Property<string>("ErrorMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "errorMessage");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "mobileNumber");

                    b.Property<string>("RequestId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "requestId");

                    b.Property<string>("RequestTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "requestTime");

                    b.Property<string>("RequestUuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "requestUUID");

                    b.Property<string>("RespCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "respCategory");

                    b.Property<long>("RespCode")
                        .HasColumnType("bigint")
                        .HasAnnotation("Relational:JsonPropertyName", "respCode");

                    b.Property<string>("RespDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "respDesc");

                    b.Property<long>("RiskScore")
                        .HasColumnType("bigint")
                        .HasAnnotation("Relational:JsonPropertyName", "riskscore");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "status");

                    b.HasKey("Rrn");

                    b.ToTable("RiskScoreResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
