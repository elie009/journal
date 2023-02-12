namespace Journal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JournalContext2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JournalDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        journal_id = c.String(),
                        sign = c.String(),
                        type = c.String(),
                        account = c.String(),
                        reftype = c.String(),
                        refno = c.String(),
                        amount = c.Single(nullable: false),
                        costcenter = c.String(),
                        narration = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JournalDetails");
        }
    }
}
