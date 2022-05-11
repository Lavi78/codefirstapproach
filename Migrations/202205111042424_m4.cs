namespace codefirstapproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.emps",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        add = c.String(),
                        salary = c.Int(nullable: false),
                        phn = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.emps");
        }
    }
}
