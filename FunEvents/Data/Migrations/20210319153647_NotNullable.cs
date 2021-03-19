using Microsoft.EntityFrameworkCore.Migrations;

namespace FunEvents.Data.Migrations
{
    public partial class NotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Attendee",
                newName: "Email");

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerID",
                table: "Event",
                column: "OrganizerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.DropTable(
                name: "Organizer");

            migrationBuilder.DropIndex(
                name: "IX_Event_OrganizerID",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Attendee",
                newName: "email");
        }
    }
}
