namespace Journal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JournalContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JournalItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        voucher_code = c.String(),
                        date = c.DateTime(nullable: false),
                        payee = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JournalItems");
        }
    }
}
