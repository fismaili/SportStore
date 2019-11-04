using Microsoft.EntityFrameworkCore.Migrations;

namespace SportStore.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Products values ('Kayak','A boat for one person',275,'Watersports')");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
