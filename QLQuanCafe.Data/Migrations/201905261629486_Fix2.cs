namespace QLQuanCafe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Tables", "AreaID");
            AddForeignKey("dbo.Tables", "AreaID", "dbo.Areas", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tables", "AreaID", "dbo.Areas");
            DropIndex("dbo.Tables", new[] { "AreaID" });
        }
    }
}
