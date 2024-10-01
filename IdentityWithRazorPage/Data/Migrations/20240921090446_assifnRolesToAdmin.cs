using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityWithRazorPage.Data.Migrations
{
    /// <inheritdoc />
    public partial class assifnRolesToAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert Into [Security].[UserRoles] (UserId,RoleId) Select '55164da4-33bc-4f47-91a3-c813ca8a1961',Id From [Security].[Roles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From  [Security].[UserRoles] Where UserId = '55164da4-33bc-4f47-91a3-c813ca8a1961'");
        }
    }
}
