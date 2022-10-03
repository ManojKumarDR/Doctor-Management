using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorSampleApp.Migrations
{
    public partial class DoctorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorTable",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(nullable: true),
                    DoctorDept = table.Column<string>(nullable: true),
                    DoctorQualification = table.Column<string>(nullable: true),
                    DoctorFees = table.Column<int>(nullable: false),
                    DoctorImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorTable", x => x.DoctorId);
                });

            migrationBuilder.InsertData(
                table: "DoctorTable",
                columns: new[] { "DoctorId", "DoctorDept", "DoctorFees", "DoctorImage", "DoctorName", "DoctorQualification" },
                values: new object[] { 111, "Surgery", 85000, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimages.picxy.com%2Fcache%2F2020%2F7%2F11%2Ff10937541521489a327848bdd5e4d3ea.jpg&imgrefurl=https%3A%2F%2Fwww.picxy.com%2Fphoto%2F911013&tbnid=z5-jNdTZ2jVjRM&vet=12ahUKEwjXsOnFvcP6AhU6omoFHc-QDwMQMygmegUIARC3Ag..i&docid=lV6XLSPp0t7yRM&w=1068&h=1600&q=doctor%20images&ved=2ahUKEwjXsOnFvcP6AhU6omoFHc-QDwMQMygmegUIARC3Ag", "Krishna", "MBBS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorTable");
        }
    }
}
