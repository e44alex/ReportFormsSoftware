using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    UNK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HigherOrgUNK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.UNK);
                    table.ForeignKey(
                        name: "FK_Organisations_Organisations_HigherOrgUNK",
                        column: x => x.HigherOrgUNK,
                        principalTable: "Organisations",
                        principalColumn: "UNK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportFormHeads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cls = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Paragraph = table.Column<int>(type: "int", nullable: false),
                    SubPragraph = table.Column<int>(type: "int", nullable: false),
                    Program = table.Column<int>(type: "int", nullable: false),
                    SubProgram = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PeriodicType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFormHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportPeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronym = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisationUNK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Users_Organisations_OrganisationUNK",
                        column: x => x.OrganisationUNK,
                        principalTable: "Organisations",
                        principalColumn: "UNK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportFormDatas",
                columns: table => new
                {
                    FormHeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganisationId = table.Column<int>(type: "int", nullable: false),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    C1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C22 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFormDatas", x => new { x.FormHeadId, x.OrganisationId, x.RowCode, x.ReportPeriodId });
                    table.ForeignKey(
                        name: "FK_ReportFormDatas_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "UNK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportFormDatas_ReportFormHeads_FormHeadId",
                        column: x => x.FormHeadId,
                        principalTable: "ReportFormHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportFormDatas_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalTable: "ReportPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportForms",
                columns: table => new
                {
                    FormHeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormDataId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormDataFormHeadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FormDataOrganisationId = table.Column<int>(type: "int", nullable: true),
                    FormDataRowCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FormDataReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportForms", x => new { x.FormHeadId, x.FormDataId });
                    table.ForeignKey(
                        name: "FK_ReportForms_ReportFormDatas_FormDataFormHeadId_FormDataOrganisationId_FormDataRowCode_FormDataReportPeriodId",
                        columns: x => new { x.FormDataFormHeadId, x.FormDataOrganisationId, x.FormDataRowCode, x.FormDataReportPeriodId },
                        principalTable: "ReportFormDatas",
                        principalColumns: new[] { "FormHeadId", "OrganisationId", "RowCode", "ReportPeriodId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportForms_ReportFormHeads_FormHeadId",
                        column: x => x.FormHeadId,
                        principalTable: "ReportFormHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_HigherOrgUNK",
                table: "Organisations",
                column: "HigherOrgUNK");

            migrationBuilder.CreateIndex(
                name: "IX_ReportFormDatas_OrganisationId",
                table: "ReportFormDatas",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportFormDatas_ReportPeriodId",
                table: "ReportFormDatas",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportForms_FormDataFormHeadId_FormDataOrganisationId_FormDataRowCode_FormDataReportPeriodId",
                table: "ReportForms",
                columns: new[] { "FormDataFormHeadId", "FormDataOrganisationId", "FormDataRowCode", "FormDataReportPeriodId" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganisationUNK",
                table: "Users",
                column: "OrganisationUNK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportForms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ReportFormDatas");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "ReportFormHeads");

            migrationBuilder.DropTable(
                name: "ReportPeriods");
        }
    }
}
