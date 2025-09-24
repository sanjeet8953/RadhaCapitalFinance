using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadhaCapitalFinance.Migrations
{
    public partial class ChangeInsurenceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Convert InsurenceType to string (text)
            migrationBuilder.Sql(@"
                ALTER TABLE ""Car""
                ALTER COLUMN ""InsurenceType"" TYPE text
                USING ""InsurenceType""::text;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert back to previous type (example int)
            migrationBuilder.Sql(@"
                ALTER TABLE ""Car""
                ALTER COLUMN ""InsurenceType"" TYPE int
                USING ""InsurenceType""::integer;
            ");
        }
    }
}
