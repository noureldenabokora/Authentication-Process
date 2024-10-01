using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityWithRazorPage.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefalutRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                  table: "Roles",
                  columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                  values: new object[] { Guid.NewGuid().ToString(), "User", "User".ToUpper(), Guid.NewGuid().ToString(), },
                  schema: "Security"
                  );

            migrationBuilder.InsertData(
                 table: "Roles",
                 columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                 values: new object[]{Guid.NewGuid().ToString(),"Admin","Admin".ToUpper(),Guid.NewGuid().ToString(),},
                 schema: "Security"
                 );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [Security].[Roles]");
        }
    }
}

