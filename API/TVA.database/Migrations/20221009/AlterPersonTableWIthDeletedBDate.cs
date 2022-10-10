using FluentMigrator;

namespace TVA.database.Migrations._20221009
{
    [Migration(20221009)]
    public class AlterPersonTableWIthDeletedBDate : Migration
    {
        public override void Down()
        {
            Delete.Column("DeletedDate").FromTable("Persons");
        }

        public override void Up()
        {
            Alter.Table("Persons").AddColumn("DeletedDate").AsDateTime().Nullable();
        }
    }
}
