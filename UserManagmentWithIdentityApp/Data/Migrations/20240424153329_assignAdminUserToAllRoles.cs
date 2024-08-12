using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagmentWithIdentityApp.Data.Migrations
{
    public partial class assignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into [security].[UserRoles] (UserId,RoleId) select '9759c3ab-103f-4c5c-aac2-f73019600297',Id from [Security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Security].[UserRoles] where UserId = '9759c3ab-103f-4c5c-aac2-f73019600297' ");
        }
    }
}
