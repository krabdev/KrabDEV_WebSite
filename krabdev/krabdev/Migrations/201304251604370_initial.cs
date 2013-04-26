namespace krabdev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FAQs",
                c => new
                    {
                        FAQId = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false),
                        Anwser = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FAQId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FAQs");
        }
    }
}
