using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuantityMesurement_API.Migrations
{
    public partial class QMCommanLayerModelsQuantityMesurementContext1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuantityMesurementCompareTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ValueOne = table.Column<double>(nullable: false),
                    UnitOfValueOne = table.Column<string>(nullable: false),
                    ValueTwo = table.Column<double>(nullable: false),
                    UnitOfValueTwo = table.Column<string>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    DateOnCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantityMesurementCompareTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuantityMesurementCompareTable");
        }
    }
}
