﻿namespace PlutoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert INTO Categories VALUES (1, 'Web Developement')");
            Sql("Insert INTO Categories VALUES (2, 'Programming Languages')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
