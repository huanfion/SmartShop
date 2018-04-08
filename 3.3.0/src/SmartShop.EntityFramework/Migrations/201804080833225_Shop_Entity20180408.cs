namespace SmartShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shop_Entity20180408 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        Name = c.String(),
                        SortID = c.Int(),
                        IsUse = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        ArticleType = c.Int(nullable: false),
                        ClassName = c.String(),
                        FolderName = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                        IsAsNavigation = c.Boolean(nullable: false),
                        IsToNewWindow = c.Boolean(nullable: false),
                        IsLink = c.Boolean(nullable: false),
                        LinkUrl = c.String(),
                        Contents = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        IsAuditing = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClassID = c.Int(nullable: false),
                        ArticleType = c.Int(nullable: false),
                        IsContributed = c.Boolean(nullable: false),
                        Title = c.String(),
                        ShortTitle = c.String(),
                        Click = c.Int(nullable: false),
                        Writer = c.String(),
                        Source = c.String(),
                        SourceUrl = c.String(),
                        IsSlide = c.Boolean(nullable: false),
                        IsRecommend = c.Boolean(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        FeaturedImage = c.String(),
                        Summary = c.String(),
                        Body = c.String(),
                        Tags = c.String(),
                        UpdateTime = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Case",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Summary = c.String(),
                        Cover = c.String(),
                        Url = c.String(),
                        CreateTime = c.DateTime(),
                        DisplayOrder = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        CompanyID = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        Ico = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        IsChecked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HelpCatalog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HelpDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CatalogId = c.Int(),
                        Type = c.Int(),
                        Title = c.String(),
                        Summary = c.String(),
                        Answer = c.String(),
                        UpdateTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                        DisplayOrder = c.Int(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTAdmin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(),
                        LoginName = c.String(),
                        LoginPassword = c.String(),
                        UserName = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        QQ = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        LastLoginTime = c.DateTime(),
                        LastLoginIP = c.String(),
                        LoginCount = c.Int(nullable: false),
                        ErrorCount = c.Int(),
                        IsCompanyAdmin = c.Int(),
                        LastSefetyTime = c.DateTime(),
                        Status = c.Int(nullable: false),
                        OpenId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTAdminSafety",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(),
                        OldPassword = c.String(),
                        NewPassword = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTApplicationNode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(),
                        Depth = c.Int(nullable: false),
                        ChildCount = c.Int(nullable: false),
                        NodeName = c.String(),
                        NodeKey = c.String(),
                        Url = c.String(),
                        Description = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        Description = c.String(),
                        Ico = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTPermissionInAdmin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemKey = c.String(),
                        AdminID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTPermissionInGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemKey = c.String(),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTPermissionInRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemKey = c.String(),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTPermission",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemKey = c.String(),
                        AppID = c.Int(nullable: false),
                        ItemName = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTRoleInGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        Description = c.String(),
                        Ico = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HTUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(),
                        GroupID = c.Int(),
                        UserName = c.String(),
                        LoginPassword = c.String(),
                        Email = c.String(),
                        IsEmailVerified = c.Boolean(nullable: false),
                        Mobile = c.String(),
                        IsMobileVerified = c.Boolean(nullable: false),
                        RealName = c.String(),
                        NickName = c.String(),
                        IsActivated = c.Boolean(nullable: false),
                        Gender = c.String(),
                        Avatar = c.String(),
                        Job = c.String(),
                        Tel = c.String(),
                        ProvinceID = c.Int(),
                        Province = c.String(),
                        CityID = c.Int(),
                        City = c.String(),
                        AreaID = c.Int(),
                        Area = c.String(),
                        Address = c.String(),
                        Birthday = c.String(),
                        LunarBirthday = c.String(),
                        CreateTime = c.DateTime(),
                        CreateIP = c.String(),
                        OpenId = c.String(),
                        UnionId = c.String(),
                        Status = c.Int(),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MicroAlbum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteId = c.Int(),
                        Type = c.Int(),
                        Name = c.String(),
                        UpdateTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MicroAlbumPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlbumId = c.Int(),
                        PhotoPath = c.String(),
                        Remark = c.String(),
                        IsDelete = c.Int(),
                        IsUse = c.Int(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MicroCoupon",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteId = c.Int(),
                        Title = c.String(),
                        Remark = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MicroSite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        IsExp = c.Int(),
                        Name = c.String(),
                        Logo = c.String(),
                        Phone = c.String(),
                        Phone2 = c.String(),
                        Fax = c.String(),
                        Lat = c.String(),
                        Lng = c.String(),
                        Address = c.String(),
                        About = c.String(),
                        Service = c.String(),
                        Industry = c.String(),
                        FromKey = c.String(),
                        IsDefault = c.Int(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                        UpdateTime = c.DateTime(),
                        Template = c.String(),
                        Domain = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhoneValid",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Phone = c.String(),
                        Code = c.String(),
                        CreateTime = c.DateTime(),
                        IsValid = c.Int(),
                        ValidTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QRcode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        SceneId = c.Int(),
                        SceneStr = c.String(),
                        Ticket = c.String(),
                        ExpireTime = c.DateTime(),
                        Url = c.String(),
                        OpenId = c.String(),
                        UseStatus = c.Int(),
                        LastUseTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceReserve",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteId = c.Int(),
                        Type = c.String(),
                        UserName = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        District = c.String(),
                        AccessDate = c.String(),
                        AccessTime = c.String(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                        UpdateTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopCart",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(),
                        ProductId = c.Int(),
                        ProductName = c.String(),
                        ProductPic = c.String(),
                        MemberId = c.Int(),
                        CookieTag = c.String(),
                        TotPrice = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(precision: 18, scale: 2),
                        ProductNum = c.Int(),
                        CreateTime = c.DateTime(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopOrderItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mode = c.String(),
                        OrderID = c.Int(),
                        OrderNo = c.String(),
                        ProductId = c.Int(),
                        ProductNo = c.String(),
                        ProductName = c.String(),
                        ProdcutPic = c.String(),
                        Quantity = c.Int(),
                        Unit = c.String(),
                        Fee = c.Decimal(precision: 18, scale: 2),
                        OriginalFee = c.Decimal(precision: 18, scale: 2),
                        Readme = c.String(),
                        IsRemove = c.Int(),
                        IsUse = c.Int(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(),
                        CompanyId = c.Int(),
                        OrderType = c.Int(),
                        OrderNo = c.String(),
                        Fee = c.Decimal(precision: 18, scale: 2),
                        OriginalFee = c.Decimal(precision: 18, scale: 2),
                        OpenId = c.String(),
                        Phone = c.String(),
                        UserName = c.String(),
                        Address = c.String(),
                        Remarks = c.String(),
                        IsUse = c.Int(),
                        IsRefund = c.Int(),
                        IsRemove = c.Int(),
                        PayType = c.Int(),
                        PayStatus = c.Int(),
                        PayNo = c.String(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                        CreateTime = c.DateTime(),
                        CreateDate = c.String(),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopPayOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(),
                        AdminId = c.Int(),
                        Type = c.String(),
                        BusinPayType = c.String(),
                        Scenes = c.String(),
                        OtherId = c.String(),
                        OrderNo = c.String(),
                        TotalMoney = c.Int(),
                        MchId = c.String(),
                        ProductId = c.String(),
                        Body = c.String(),
                        OpenId = c.String(),
                        IsSubscribe = c.Int(),
                        PayNo = c.String(),
                        CreateTime = c.DateTime(),
                        CreateDate = c.String(),
                        UpdateTime = c.DateTime(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopProductClass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(),
                        ParentID = c.Int(),
                        ClassName = c.String(),
                        Description = c.String(),
                        DisplayOrder = c.Int(),
                        IsRemove = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopProduct",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(),
                        ProductNo = c.String(),
                        CategoryID = c.Int(nullable: false),
                        Mode = c.String(),
                        ProductType = c.String(),
                        Name = c.String(),
                        Title = c.String(),
                        SubTitle = c.String(),
                        Background = c.String(),
                        Cover = c.String(),
                        ImageList = c.String(),
                        Templet = c.String(),
                        CanCount = c.Int(),
                        ValidityDay = c.Int(),
                        Unit = c.String(),
                        OrigPrice = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(),
                        Sales = c.Int(),
                        IsRecommend = c.Int(),
                        IsHot = c.Int(),
                        IsTop = c.Int(),
                        SortID = c.Int(nullable: false),
                        Summary = c.String(),
                        Detail = c.String(),
                        IsRemove = c.Int(),
                        IsActivity = c.Int(),
                        Status = c.Int(),
                        StatusMessage = c.String(),
                        UpdateTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShopProduct");
            DropTable("dbo.ShopProductClass");
            DropTable("dbo.ShopPayOrder");
            DropTable("dbo.ShopOrder");
            DropTable("dbo.ShopOrderItem");
            DropTable("dbo.ShopCart");
            DropTable("dbo.ServiceReserve");
            DropTable("dbo.QRcode");
            DropTable("dbo.PhoneValid");
            DropTable("dbo.MicroSite");
            DropTable("dbo.MicroCoupon");
            DropTable("dbo.MicroAlbumPhoto");
            DropTable("dbo.MicroAlbum");
            DropTable("dbo.HTUser");
            DropTable("dbo.HTRole");
            DropTable("dbo.HTRoleInGroup");
            DropTable("dbo.HTPermission");
            DropTable("dbo.HTPermissionInRole");
            DropTable("dbo.HTPermissionInGroup");
            DropTable("dbo.HTPermissionInAdmin");
            DropTable("dbo.HTGroup");
            DropTable("dbo.HTApplicationNode");
            DropTable("dbo.HTAdminSafety");
            DropTable("dbo.HTAdmin");
            DropTable("dbo.HelpDetail");
            DropTable("dbo.HelpCatalog");
            DropTable("dbo.Group");
            DropTable("dbo.Case");
            DropTable("dbo.Article");
            DropTable("dbo.ArticleClass");
            DropTable("dbo.Area");
        }
    }
}
