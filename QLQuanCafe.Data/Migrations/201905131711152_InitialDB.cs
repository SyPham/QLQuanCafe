namespace QLQuanCafe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Image = c.String(storeType: "xml"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        BillDetailID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        BillID = c.Int(nullable: false),
                        BonusID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                        Percent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BillDetailID);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TableID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        Reduce = c.Double(nullable: false),
                        Pay = c.Double(nullable: false),
                        CancelTable = c.Boolean(nullable: false),
                        DateTime = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdataBy = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Bonuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemID = c.Int(nullable: false),
                        Percent = c.Int(nullable: false),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        DateTime = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdataBy = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroupItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        DateTime = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdataBy = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupItemID = c.Int(nullable: false),
                        Name = c.String(maxLength: 255),
                        Price = c.Double(nullable: false),
                        Image = c.String(storeType: "xml"),
                        DateTime = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdataBy = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PermisionDetails",
                c => new
                    {
                        PermisionDetailID = c.Int(nullable: false, identity: true),
                        PermisionID = c.Int(nullable: false),
                        ActionName = c.String(maxLength: 255),
                        ActionCode = c.String(maxLength: 255),
                        CheckAciont = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PermisionDetailID);
            
            CreateTable(
                "dbo.Permisions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AreaID = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        DateTime = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdataBy = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserPermisions",
                c => new
                    {
                        UserPermisionID = c.Int(nullable: false, identity: true),
                        PermisionID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Licensed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserPermisionID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 100),
                        Status = c.Boolean(nullable: false),
                        BirthDay = c.DateTime(),
                        Address = c.String(maxLength: 255),
                        Mobi = c.String(),
                        Email = c.String(maxLength: 255),
                        CMND = c.String(),
                        Username = c.String(maxLength: 100),
                        Password = c.String(),
                        Avatar = c.String(storeType: "xml"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserPermisions");
            DropTable("dbo.Tables");
            DropTable("dbo.Permisions");
            DropTable("dbo.PermisionDetails");
            DropTable("dbo.Items");
            DropTable("dbo.GroupItems");
            DropTable("dbo.Bonuses");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
            DropTable("dbo.Areas");
        }
    }
}
