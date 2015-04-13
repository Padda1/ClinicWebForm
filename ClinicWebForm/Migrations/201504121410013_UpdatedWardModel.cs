namespace ClinicWebForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedWardModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wards", "WardDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wards", "WardDescription", c => c.String());
        }
    }
}
