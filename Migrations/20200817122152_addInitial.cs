using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPACS.Migrations
{
    public partial class addInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administratorModel",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(nullable: false),
                    AdminEmail = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administratorModel", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "customerModel",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    is_Father = table.Column<bool>(nullable: false),
                    FatherFirstName = table.Column<string>(nullable: true),
                    FatherMiddleName = table.Column<string>(nullable: true),
                    FatherLastName = table.Column<string>(nullable: true),
                    FatherAge = table.Column<DateTime>(nullable: true),
                    is_Mother = table.Column<bool>(nullable: false),
                    MotherFirstName = table.Column<string>(nullable: true),
                    MotherMiddleName = table.Column<string>(nullable: true),
                    MotherLastName = table.Column<string>(nullable: true),
                    MotherAge = table.Column<DateTime>(nullable: true),
                    is_Daughter = table.Column<bool>(nullable: false),
                    DaughterFirstName = table.Column<string>(nullable: true),
                    DaughterMiddleName = table.Column<string>(nullable: true),
                    DaughterLastName = table.Column<string>(nullable: true),
                    DaughterAge = table.Column<DateTime>(nullable: true),
                    is_Son = table.Column<bool>(nullable: false),
                    SonFirstName = table.Column<string>(nullable: true),
                    SonMiddleName = table.Column<string>(nullable: true),
                    SonLastName = table.Column<string>(nullable: true),
                    SonAge = table.Column<DateTime>(nullable: true),
                    is_Spouse = table.Column<bool>(nullable: false),
                    SpouseFirstName = table.Column<string>(nullable: true),
                    SpouseMiddleName = table.Column<string>(nullable: true),
                    SpouseLastName = table.Column<string>(nullable: true),
                    SpouseAge = table.Column<DateTime>(nullable: true),
                    SpouseGender = table.Column<string>(nullable: true),
                    is_Gaurdian = table.Column<bool>(nullable: false),
                    GaurdianFirstName = table.Column<string>(nullable: true),
                    GaurdianMiddleName = table.Column<string>(nullable: true),
                    GaurdianLastName = table.Column<string>(nullable: true),
                    GaurdianGender = table.Column<DateTime>(nullable: true),
                    CustomerMobileNumber = table.Column<long>(nullable: true),
                    AlternativeContactNumber = table.Column<long>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerCaste = table.Column<string>(nullable: true),
                    CustomerSubCaste = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<long>(nullable: true),
                    AADHARNo = table.Column<long>(nullable: true),
                    PAN = table.Column<string>(nullable: true),
                    DrivingLicense = table.Column<string>(nullable: true),
                    VoterID = table.Column<string>(nullable: true),
                    RationCard = table.Column<string>(nullable: true),
                    Housenumber = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MapsLink = table.Column<string>(nullable: true),
                    Village_City = table.Column<string>(nullable: true),
                    Taluk = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Pincode = table.Column<int>(nullable: true),
                    RelationwithCustomer = table.Column<string>(nullable: true),
                    NomineeFullName = table.Column<string>(nullable: true),
                    NomineeDOB = table.Column<DateTime>(nullable: true),
                    NomineeAddress = table.Column<string>(nullable: true),
                    NomineeVillage = table.Column<string>(nullable: true),
                    NomineeTaluk = table.Column<string>(nullable: true),
                    NomineeDistrict = table.Column<string>(nullable: true),
                    NomineePincode = table.Column<int>(nullable: true),
                    NomineeContactNumber = table.Column<int>(nullable: true),
                    is_minor = table.Column<bool>(nullable: false),
                    GaurdianFullName = table.Column<string>(nullable: true),
                    GaurdianDateofBirth = table.Column<DateTime>(nullable: true),
                    GaurdianAddress = table.Column<string>(nullable: true),
                    GaurdianVillage = table.Column<string>(nullable: true),
                    GaurdianTaluk = table.Column<string>(nullable: true),
                    GaurdianDistrict = table.Column<string>(nullable: true),
                    GaurdianPincode = table.Column<int>(nullable: true),
                    GaurdianContactNumber = table.Column<int>(nullable: true),
                    ApplicationDateUpdated = table.Column<DateTime>(nullable: true),
                    ApplicationDateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerModel", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "DCCBmodel",
                columns: table => new
                {
                    DccbID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCCBmodel", x => x.DccbID);
                });

            migrationBuilder.CreateTable(
                name: "DepositModel",
                columns: table => new
                {
                    DepositID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositModel", x => x.DepositID);
                });

            migrationBuilder.CreateTable(
                name: "FinYear_ROImodel",
                columns: table => new
                {
                    FinYear_ROI_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinYear_ROImodel", x => x.FinYear_ROI_ID);
                });

            migrationBuilder.CreateTable(
                name: "SCBmodel",
                columns: table => new
                {
                    SCB_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCBmodel", x => x.SCB_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administratorModel");

            migrationBuilder.DropTable(
                name: "customerModel");

            migrationBuilder.DropTable(
                name: "DCCBmodel");

            migrationBuilder.DropTable(
                name: "DepositModel");

            migrationBuilder.DropTable(
                name: "FinYear_ROImodel");

            migrationBuilder.DropTable(
                name: "SCBmodel");
        }
    }
}
