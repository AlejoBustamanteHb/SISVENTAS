namespace PROYECTO_FINAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'3bb77674-5da4-4ed6-96fd-c9ae792e7290', N'Administrador', N'AMLiTgmBfXu7s+XI7JH9/E2XbiKgbt5hbXogMRU/Cz/3+HyffpSHZzY3+10wEs0G+w==', N'08df7283-d510-444f-9070-da7de682c6a0', N'ApplicationUser')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'45e2acd4-8826-4326-b6dc-1f9837d3d477', N'luis', N'AABUi3iVfVfrlBzF7YBYWjGLlC+PFiPEz7T2kfjHstLYRbacLRo2onf3cwmXpfYRGg==', N'80355dae-a851-4917-be6d-b7d89e7ac7a1', N'ApplicationUser')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9ae25483-f554-41eb-a66d-247de9c63403', N'Administrador')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3bb77674-5da4-4ed6-96fd-c9ae792e7290', N'9ae25483-f554-41eb-a66d-247de9c63403')
                
            ");
        }
        
        public override void Down()
        {
        }
    }
}
