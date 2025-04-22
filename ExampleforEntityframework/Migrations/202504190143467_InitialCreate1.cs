namespace ExampleforEntityframework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "Pincode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Pincode");
            DropColumn("dbo.Employees", "Address");
        }
    }
}
