namespace QLQuanCafe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Areas", "DateTime", c => c.DateTime());
            AddColumn("dbo.Areas", "CreateBy", c => c.String(maxLength: 255));
            AddColumn("dbo.Areas", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Areas", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Areas", "UpdataBy", c => c.String(maxLength: 255));
            AddColumn("dbo.Areas", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bills", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Bonuses", "CreateDate", c => c.DateTime());
            AddColumn("dbo.GroupItems", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Items", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Tables", "CreateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tables", "CreateDate");
            DropColumn("dbo.Items", "CreateDate");
            DropColumn("dbo.GroupItems", "CreateDate");
            DropColumn("dbo.Bonuses", "CreateDate");
            DropColumn("dbo.Bills", "CreateDate");
            DropColumn("dbo.Areas", "Status");
            DropColumn("dbo.Areas", "UpdataBy");
            DropColumn("dbo.Areas", "UpdateDate");
            DropColumn("dbo.Areas", "CreateDate");
            DropColumn("dbo.Areas", "CreateBy");
            DropColumn("dbo.Areas", "DateTime");
        }
    }
}
