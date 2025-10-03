using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RadhaCapitalFinance.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminName = table.Column<string>(type: "text", nullable: true),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    MobailNo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    ConformPassword = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CarName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CarType = table.Column<string>(type: "text", nullable: false),
                    RegistrationNo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    ManufacturingYear = table.Column<int>(type: "integer", nullable: false),
                    FuelType = table.Column<string>(type: "text", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    InsurenceType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Commercial",
                columns: table => new
                {
                    PolicyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusinessName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    BusinessType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Pincode = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PolicyStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PolicyEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SumInsured = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Premium = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commercial", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "Fire",
                columns: table => new
                {
                    PolicyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InsuredName = table.Column<string>(type: "varchar(100)", nullable: false),
                    PropertyAdderess = table.Column<string>(type: "varchar(250)", nullable: false),
                    PolicyStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SumInsured = table.Column<decimal>(type: "numeric", nullable: false),
                    Premium = table.Column<decimal>(type: "numeric", nullable: false),
                    PropertyType = table.Column<string>(type: "text", nullable: false),
                    Pincode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fire", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "Helth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    InsurenceType = table.Column<string>(type: "text", nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Pincode = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    NoOffPeople = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mobile = table.Column<string>(type: "varchar(20)", nullable: false),
                    Consent = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Life",
                columns: table => new
                {
                    PolicyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PolicyHolderName = table.Column<string>(type: "varchar(100)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    MobailNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pincode = table.Column<string>(type: "text", nullable: true),
                    NomineeName = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomineeRelation = table.Column<string>(type: "varchar(50)", nullable: false),
                    PolicyStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    SumAssured = table.Column<decimal>(type: "numeric", nullable: false),
                    Premium = table.Column<decimal>(type: "numeric", nullable: false),
                    PremiumMode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Life", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "Marine",
                columns: table => new
                {
                    PolicyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PolicyHolderName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CargoDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    DeparturePort = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DestinationPort = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransportMode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SumInsured = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Premium = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    RiskCoverage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marine", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PropertyHolderName = table.Column<string>(type: "varchar(100)", nullable: false),
                    MobailNo = table.Column<string>(type: "varchar(50)", nullable: false),
                    PropertyName = table.Column<string>(type: "varchar(50)", nullable: false),
                    PropertyAdderess = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pincode = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Consent = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Retirement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Pincode = table.Column<string>(type: "text", nullable: false),
                    Current_Age = table.Column<string>(type: "text", nullable: false),
                    YearofRetirement = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retirement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MobileNo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Travel",
                columns: table => new
                {
                    TravelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    MobileNo = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    TotalMembers = table.Column<int>(type: "integer", nullable: false),
                    DateofDeparture = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateofArrival = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.TravelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Commercial");

            migrationBuilder.DropTable(
                name: "Fire");

            migrationBuilder.DropTable(
                name: "Helth");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "Life");

            migrationBuilder.DropTable(
                name: "Marine");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Retirement");

            migrationBuilder.DropTable(
                name: "SIP");

            migrationBuilder.DropTable(
                name: "Travel");
        }
    }
}
