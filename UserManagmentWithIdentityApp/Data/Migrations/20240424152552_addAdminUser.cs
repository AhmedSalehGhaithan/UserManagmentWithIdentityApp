using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagmentWithIdentityApp.Data.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'9759c3ab-103f-4c5c-aac2-f73019600297', N'Mohamed', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEPw0K8lszrtoniWZaCRXbcM6eVkySahbO+h16YIVuOwtOejXOdnPzqy5zUuWY21T2Q==', N'M45XZKHRWYYN7CEFEA53M7EH2D7YFE3R', N'ab71abb8-2091-4d25-b221-5a039bc1d1fe', NULL, 0, 0, NULL, 1, 0, N'Muhammad', N'ElHelaly', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Security].[Users] WHERE Id = '9759c3ab-103f-4c5c-aac2-f73019600297'");
        }
    }
}
