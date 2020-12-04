using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrIsler.DataAccess.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgrBilgi",
                columns: table => new
                {
                    OgrNo = table.Column<string>(maxLength: 9, nullable: false),
                    Adi = table.Column<string>(maxLength: 15, nullable: false),
                    Soyadi = table.Column<string>(maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<bool>(nullable: false),
                    Dtarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrBilgi", x => x.OgrNo);
                });

            migrationBuilder.CreateTable(
                name: "OgrBolum",
                columns: table => new
                {
                    Bkodu = table.Column<string>(maxLength: 3, nullable: false),
                    Badi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrBolum", x => x.Bkodu);
                });

            migrationBuilder.CreateTable(
                name: "OgrDanisman",
                columns: table => new
                {
                    Dkodu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dadi = table.Column<string>(maxLength: 15, nullable: false),
                    Dsoyadi = table.Column<string>(maxLength: 20, nullable: false),
                    Bkodu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrDanisman", x => x.Dkodu);
                    table.ForeignKey(
                        name: "FK_OgrDanisman_OgrBolum_Bkodu",
                        column: x => x.Bkodu,
                        principalTable: "OgrBolum",
                        principalColumn: "Bkodu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OgrProgram",
                columns: table => new
                {
                    Pkodu = table.Column<string>(maxLength: 3, nullable: false),
                    Padi = table.Column<string>(nullable: false),
                    Bkodu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrProgram", x => x.Pkodu);
                    table.ForeignKey(
                        name: "FK_OgrProgram_OgrBolum_Bkodu",
                        column: x => x.Bkodu,
                        principalTable: "OgrBolum",
                        principalColumn: "Bkodu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OgrOkul",
                columns: table => new
                {
                    OgrNo = table.Column<string>(maxLength: 9, nullable: false),
                    Sinif = table.Column<byte>(nullable: false),
                    Pkodu = table.Column<string>(nullable: true),
                    Dkodu = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrOkul", x => x.OgrNo);
                    table.ForeignKey(
                        name: "FK_OgrOkul_OgrDanisman_Dkodu",
                        column: x => x.Dkodu,
                        principalTable: "OgrDanisman",
                        principalColumn: "Dkodu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OgrOkul_OgrBilgi_OgrNo",
                        column: x => x.OgrNo,
                        principalTable: "OgrBilgi",
                        principalColumn: "OgrNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrOkul_OgrProgram_Pkodu",
                        column: x => x.Pkodu,
                        principalTable: "OgrProgram",
                        principalColumn: "Pkodu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrDanisman_Bkodu",
                table: "OgrDanisman",
                column: "Bkodu");

            migrationBuilder.CreateIndex(
                name: "IX_OgrOkul_Dkodu",
                table: "OgrOkul",
                column: "Dkodu");

            migrationBuilder.CreateIndex(
                name: "IX_OgrOkul_Pkodu",
                table: "OgrOkul",
                column: "Pkodu");

            migrationBuilder.CreateIndex(
                name: "IX_OgrProgram_Bkodu",
                table: "OgrProgram",
                column: "Bkodu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrOkul");

            migrationBuilder.DropTable(
                name: "OgrDanisman");

            migrationBuilder.DropTable(
                name: "OgrBilgi");

            migrationBuilder.DropTable(
                name: "OgrProgram");

            migrationBuilder.DropTable(
                name: "OgrBolum");
        }
    }
}
