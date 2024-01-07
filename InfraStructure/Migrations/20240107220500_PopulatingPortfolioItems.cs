using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfraStructure.Migrations
{
    public partial class PopulatingPortfolioItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "Address", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("343bc5c9-4005-4785-8321-d321de4e727f"), "Cairo", "avatar.jpg", "MahmoudIsmail", ".Net Core Developer" });

            migrationBuilder.InsertData(
                table: "PortfolioItems",
                columns: new[] { "Id", "Description", "ImageUrl", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("1a980bad-dd0f-430f-a6ff-56f3feeba5e3"), "Ocean", "ecole.png", "Sea" },
                    { new Guid("1c8ac68d-48b6-40ab-8a32-d9f31783c0b4"), "BookStore App", "angry.png", "Bookly" },
                    { new Guid("2f0e97d1-f012-46d2-8859-8eae24306d0b"), "Dummy data", "flappy.png", "Home" },
                    { new Guid("c16a1ec3-8473-4b18-8673-1f319c8ce9a1"), "Video Rental App", "commercial.png", "Vidly" },
                    { new Guid("d9cf4576-9e56-4a97-92d0-0d04c1285d5b"), "Playstation store app", "gps.png", "Playstation" },
                    { new Guid("da0c18e8-4744-476b-82be-30ead6e9e2ff"), "Some dummy data", "instagram.png", "bla bla" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("343bc5c9-4005-4785-8321-d321de4e727f"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("1a980bad-dd0f-430f-a6ff-56f3feeba5e3"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("1c8ac68d-48b6-40ab-8a32-d9f31783c0b4"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("2f0e97d1-f012-46d2-8859-8eae24306d0b"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("c16a1ec3-8473-4b18-8673-1f319c8ce9a1"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("d9cf4576-9e56-4a97-92d0-0d04c1285d5b"));

            migrationBuilder.DeleteData(
                table: "PortfolioItems",
                keyColumn: "Id",
                keyValue: new Guid("da0c18e8-4744-476b-82be-30ead6e9e2ff"));

           
        }
    }
}
