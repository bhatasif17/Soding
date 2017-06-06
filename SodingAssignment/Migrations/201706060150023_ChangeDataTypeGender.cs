namespace SodingAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeGender : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "GenderId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "GenderId", c => c.Int(nullable: false));
        }
    }
}
