namespace ElevenBook.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reply", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Reply", "CreateUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reply", "CreateUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Reply", "CreatedUtc");
        }
    }
}
