using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VouchersDataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BalanceAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Expense = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceAccounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Expense = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Remark = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VoucherDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    VATRate = table.Column<int>(nullable: false),
                    VoucherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VoucherDetails_BalanceAccounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "BalanceAccounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoucherDetails_Vouchers_VoucherID",
                        column: x => x.VoucherID,
                        principalTable: "Vouchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoucherDetails_AccountID",
                table: "VoucherDetails",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherDetails_VoucherID",
                table: "VoucherDetails",
                column: "VoucherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoucherDetails");

            migrationBuilder.DropTable(
                name: "BalanceAccounts");

            migrationBuilder.DropTable(
                name: "Vouchers");
        }
    }
}
