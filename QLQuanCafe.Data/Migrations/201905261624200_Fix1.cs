namespace QLQuanCafe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Fix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tables", "AreaID", "dbo.Areas");
            DropIndex("dbo.Tables", new[] { "AreaID" });
        }

        public override void Down()
        {
            CreateIndex("dbo.Tables", "AreaID");
            AddForeignKey("dbo.Tables", "AreaID", "dbo.Areas", "ID", cascadeDelete: true);
        }
    }
}
