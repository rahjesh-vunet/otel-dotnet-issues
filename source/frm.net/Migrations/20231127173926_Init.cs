using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frm.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RiskScoreResponses",
                columns: table => new
                {
                    Rrn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RespCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespCode = table.Column<long>(type: "bigint", nullable: false),
                    RespDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RiskScore = table.Column<long>(type: "bigint", nullable: false),
                    RequestUuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskScoreResponses", x => x.Rrn);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RiskScoreResponses");
        }
    }
}
