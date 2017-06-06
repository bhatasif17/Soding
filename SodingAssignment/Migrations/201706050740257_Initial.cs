namespace SodingAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "GenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "GenderId", c => c.Int(nullable: false));
        }
    }
}
