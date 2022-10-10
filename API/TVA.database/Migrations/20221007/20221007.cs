using FluentMigrator;

namespace TVA.database.Migrations._20221007
{
    [Migration(20221007,TransactionBehavior.Default)]
    public class _20221007 : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            Execute.Script("./Migrations/20221007/InteractiveMVC_Tables_With_Data.sql");
        }
    }
}
