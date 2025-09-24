using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadhaCapitalFinance.Migrations
{
    /// <inheritdoc />
    public partial class Arrivel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        ALTER TABLE ""Travel""
        ALTER COLUMN ""DateofArrival"" TYPE timestamp without time zone
        USING to_date(""DateofArrival""::text, 'YYYYMMDD');
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        ALTER TABLE ""Travel""
        ALTER COLUMN ""DateofArrival"" TYPE int
        USING extract(year from ""DateofArrival"") * 10000
              + extract(month from ""DateofArrival"") * 100
              + extract(day from ""DateofArrival"");
    ");
        }
    }
}
