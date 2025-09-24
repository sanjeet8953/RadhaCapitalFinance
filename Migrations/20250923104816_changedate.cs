using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadhaCapitalFinance.Migrations
{
    public partial class changedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // DateofDeparture convert
            migrationBuilder.Sql(@"
                ALTER TABLE ""Travel""
                ALTER COLUMN ""DateofDeparture"" TYPE timestamp without time zone
                USING to_date(""DateofDeparture""::text, 'YYYYMMDD');
            ");

            // DateofArrival convert
            migrationBuilder.Sql(@"
                ALTER TABLE ""Travel""
                ALTER COLUMN ""DateofArrival"" TYPE timestamp without time zone
                USING to_date(""DateofArrival""::text, 'YYYYMMDD');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // DateofDeparture revert
            migrationBuilder.Sql(@"
                ALTER TABLE ""Travel""
                ALTER COLUMN ""DateofDeparture"" TYPE int
                USING extract(year from ""DateofDeparture"") * 10000
                      + extract(month from ""DateofDeparture"") * 100
                      + extract(day from ""DateofDeparture"");
            ");

            // DateofArrival revert
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
