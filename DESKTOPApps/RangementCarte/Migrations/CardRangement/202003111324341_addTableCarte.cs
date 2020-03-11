namespace RangementCarte.Migrations.CardRangement
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableCarte : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cartes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatriculeNational = c.String(),
                        Boxe = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Phone = c.String(),
                        EtatLivraison = c.String(),
                        Usinier = c.String(),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cartes");
        }
    }
}
