namespace PROYECTO_FINAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.articulo",
                c => new
                    {
                        idarticulo = c.Int(nullable: false, identity: true),
                        idcategoria = c.Int(nullable: false),
                        codigo = c.String(),
                        nombre = c.String(),
                        stock = c.Int(nullable: false),
                        descripcion = c.String(),
                        imagen = c.String(),
                        estado = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.idarticulo)
                .ForeignKey("dbo.categoria", t => t.idcategoria, cascadeDelete: true)
                .Index(t => t.idcategoria);
            
            CreateTable(
                "dbo.categoria",
                c => new
                    {
                        idcategoria = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        condicion = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.idcategoria);
            
            CreateTable(
                "dbo.domicilio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idventa = c.Int(nullable: false),
                        idcliente = c.Int(nullable: false),
                        direccion = c.String(),
                        persona_idpersona = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.persona", t => t.persona_idpersona)
                .ForeignKey("dbo.venta", t => t.idventa, cascadeDelete: true)
                .Index(t => t.persona_idpersona)
                .Index(t => t.idventa);
            
            CreateTable(
                "dbo.persona",
                c => new
                    {
                        idpersona = c.Int(nullable: false, identity: true),
                        tipo_persona = c.String(),
                        nombre = c.String(),
                        tipo_documento = c.String(),
                        num_documento = c.String(),
                        direccion = c.String(),
                        telefono = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.idpersona);
            
            CreateTable(
                "dbo.ingreso",
                c => new
                    {
                        idingreso = c.Int(nullable: false, identity: true),
                        idproveedor = c.Int(nullable: false),
                        tipo_comprobante = c.String(),
                        serie_comprobante = c.String(),
                        num_comprobante = c.String(),
                        fecha_hora = c.DateTime(nullable: false),
                        impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        estado = c.String(),
                        detalle_Ingreso = c.String(),
                        valor_ingreso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        persona_idpersona = c.Int(),
                    })
                .PrimaryKey(t => t.idingreso)
                .ForeignKey("dbo.persona", t => t.persona_idpersona)
                .Index(t => t.persona_idpersona);
            
            CreateTable(
                "dbo.venta",
                c => new
                    {
                        idventa = c.Int(nullable: false, identity: true),
                        idcliente = c.Int(nullable: false),
                        tipo_comprobante = c.String(),
                        serie_comprobante = c.String(),
                        num_comprobante = c.String(),
                        fecha_hora = c.DateTime(nullable: false),
                        impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        estado = c.String(),
                        detalle_venta = c.String(),
                        valor_venta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        descuento = c.Decimal(precision: 18, scale: 2),
                        persona_idpersona = c.Int(),
                    })
                .PrimaryKey(t => t.idventa)
                .ForeignKey("dbo.persona", t => t.persona_idpersona)
                .Index(t => t.persona_idpersona);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.LoginProvider, t.ProviderKey })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.venta", "persona_idpersona", "dbo.persona");
            DropForeignKey("dbo.domicilio", "idventa", "dbo.venta");
            DropForeignKey("dbo.ingreso", "persona_idpersona", "dbo.persona");
            DropForeignKey("dbo.domicilio", "persona_idpersona", "dbo.persona");
            DropForeignKey("dbo.articulo", "idcategoria", "dbo.categoria");
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.venta", new[] { "persona_idpersona" });
            DropIndex("dbo.domicilio", new[] { "idventa" });
            DropIndex("dbo.ingreso", new[] { "persona_idpersona" });
            DropIndex("dbo.domicilio", new[] { "persona_idpersona" });
            DropIndex("dbo.articulo", new[] { "idcategoria" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.venta");
            DropTable("dbo.ingreso");
            DropTable("dbo.persona");
            DropTable("dbo.domicilio");
            DropTable("dbo.categoria");
            DropTable("dbo.articulo");
        }
    }
}
